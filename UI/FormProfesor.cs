using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace UI
{
    public partial class FormProfesor : Form
    {
        private Profesor prof;

        public Profesor Prof { get => prof; set => prof = value; }

        public FormProfesor()
        {
            InitializeComponent();
        }

        public FormProfesor(Profesor p)
        {
            InitializeComponent();
            this.prof = p;
            this.textBoxProfDNI.Text = p.Dni.ToString();
            this.textBoxProfNombre.Text = p.Nombre;
            this.dateTimePickerProfFNac.Text = p.FNac.ToString();
            this.dateTimePickerProfFIng.Text = p.FIng.ToString();
            this.listBoxProfCom.DataSource = p.Comisiones;
            this.listBoxProfCom.ClearSelected();
        }

        private void checkInputs()
        {
            string a;
            if (validDni(textBoxProfDNI.Text, out a) && validNombre(textBoxProfNombre.Text, out a))
            {
                buttonProfCrear.Enabled = true;
                buttonProfModif.Enabled = true;
            }
            else
            {
                buttonProfCrear.Enabled = false;
                buttonProfModif.Enabled = false;
            }
        }

        private void buttonProfCrear_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(this.textBoxProfDNI.Text);
            string nombre = this.textBoxProfNombre.Text;
            DateTime fnac = this.dateTimePickerProfFNac.Value;
            DateTime fing = this.dateTimePickerProfFIng.Value;

            prof = new Profesor(fing, dni, nombre, fnac);

            this.Close();
        }

        private void buttonProfModif_Click(object sender, EventArgs e)
        {
            prof.Nombre = this.textBoxProfNombre.Text;
            prof.FNac = this.dateTimePickerProfFNac.Value;
            prof.FIng = this.dateTimePickerProfFIng.Value;

            // DB: Modifica al profesor en la base de datos
            prof.modificarProfesor(prof);

            this.Hide();
            MessageBox.Show("Profesor modificado satisfactoriamente.");
            this.Close();
        }

        private void buttonProfAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonProfCancelar_Click(object sender, EventArgs e)
        {
            prof = null;

            this.Close();
        }

        public void prepararFormCrear()
        {
            this.Text = "Crear Profesor";
            this.textBoxProfDNI.ReadOnly = false;
            this.buttonProfModif.Visible = false;
            this.buttonProfAceptar.Visible = false;
            this.labelProfCom.Visible = false;
            this.listBoxProfCom.Visible = false;
            this.buttonProfCrear.Visible = true;
            this.buttonProfCrear.Enabled = false;
        }

        public void prepararFormModificar()
        {
            this.Text = "Modificar Profesor";
            this.textBoxProfDNI.ReadOnly = true;
            this.buttonProfModif.Visible = true;
            this.buttonProfAceptar.Visible = false;
            this.buttonProfCrear.Visible = false;
            this.labelProfCom.Visible = false;
            this.listBoxProfCom.Visible = false;
            this.buttonProfModif.Enabled = false;
        }

        public void prepararFormMostrar()
        {
            this.Text = "Profesor";
            this.textBoxProfDNI.ReadOnly = true;
            this.textBoxProfNombre.ReadOnly = true;
            this.buttonProfAceptar.Visible = true;
            this.labelProfCom.Visible = true;
            this.listBoxProfCom.Enabled = false;
            this.dateTimePickerProfFNac.Enabled = false;
            this.dateTimePickerProfFIng.Enabled = false;
            this.buttonProfCrear.Visible = false;
            this.buttonProfModif.Visible = false;
        }

        private void textBoxProfDNI_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxProfDNI, String.Empty);
        }

        private void textBoxProfDNI_Validating(object sender, CancelEventArgs e)
        {
            string dni = textBoxProfDNI.Text;

            string errorMsg;
            if (!validDni(dni, out errorMsg))
            {
                e.Cancel = true;
                textBoxProfDNI.Focus();

                this.errorProvider.SetError(textBoxProfDNI, errorMsg);
            }
        }

        private bool validDni(string dni, out string errorMessage)
        {
            if (dni.Length < 7)
            {
                errorMessage = "El dni debe ser de 7 u 8 dígitos.";
                return false;
            }
            else if (dni.Length > 8)
            {
                errorMessage = "El dni debe ser de 8 dígitos máximo.";
                return false;
            }

            // Chequeamos con una regex que es un entero.
            if (System.Text.RegularExpressions.Regex.IsMatch(dni, "^[0-9]+$"))
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "El dni debe estar en un formato válido.\n" + "Por ejemplo: '11222333' ";
            return false;
        }

        private void textBoxProfNombre_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxProfNombre, String.Empty);
        }

        private void textBoxProfNombre_Validating(object sender, CancelEventArgs e)
        {
            string nom = textBoxProfNombre.Text;

            string errorMsg;
            if (!validNombre(nom, out errorMsg))
            {
                e.Cancel = true;
                textBoxProfNombre.Focus();

                this.errorProvider.SetError(textBoxProfNombre, errorMsg);
            }
        }

        private bool validNombre(string nom, out string errorMessage)
        {
            if (nom.Length > 40)
            {
                errorMessage = "El nombre debe ser de 40 caracteres maximo.";
                return false;
            }
            else if (nom.Length == 0)
            {
                errorMessage = "Debe ingresar un nombre.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void textBoxProfDNI_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void textBoxProfNombre_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void listBoxProfCom_Format(object sender, ListControlConvertEventArgs e)
        {
            string act = ((Comision)e.ListItem).Actividad.Descripcion;
            string id = ((Comision)e.ListItem).Id.ToString();
            string dia = ((Comision)e.ListItem).Dia;
            string horario = ((Comision)e.ListItem).Horario.ToString();

            e.Value = act + " | ID: " + id + " | Día: " + dia + " | Horario: " + horario + "hs";
        }
    }
}
