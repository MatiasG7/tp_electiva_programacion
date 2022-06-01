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
    public partial class FormActividad : Form
    {
        private Actividad act;
        private List<Profesor> profesores;
        private bool validation;

        public Actividad Act { get => act; set => act = value; }

        public FormActividad(List<Profesor> profesores)
        {
            InitializeComponent();
            this.profesores = profesores;
        }

        public FormActividad(Actividad act, List<Profesor> profesores)
        {
            InitializeComponent();
            this.profesores = profesores;
            this.act = act;
            this.textBoxActID.Text = act.Id.ToString();
            this.textBoxActDesc.Text = act.Descripcion;
            this.textBoxActCosto.Text = act.Costo.ToString();
            this.listBoxActComisiones.DataSource = act.Comisiones;
            this.listBoxActComisiones.ClearSelected();
        }

        private void checkInputs()
        {
            string a;
            if (validCosto(textBoxActCosto.Text, out a) && validDescripcion(textBoxActDesc.Text, out a))
            {
                buttonActCrear.Enabled = true;
                buttonActModif.Enabled = true;
            }
            else
            {
                buttonActCrear.Enabled = false;
                buttonActModif.Enabled = false;
            }
        }

        private void buttonActCrear_Click(object sender, EventArgs e)
        {
            double costo = double.Parse(this.textBoxActCosto.Text);
            string desc = this.textBoxActDesc.Text;
            act = new Actividad(0, desc, costo);

            this.Close();

        }

        private void buttonActModif_Click(object sender, EventArgs e)
        {
            if (textBoxActDesc.Text != "" && textBoxActCosto.Text != "")
            {
                act.Descripcion = this.textBoxActDesc.Text;
                act.Costo = double.Parse(this.textBoxActCosto.Text);

                act.modificarAct(act);//Modificar en DB

                this.Hide();
                MessageBox.Show("Actividad modificada satisfactoriamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No puede haber campos vacios.");
            }

        }

        private void buttonActAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonActCancelar_Click(object sender, EventArgs e)
        {
            act = null;

            this.Close();
        }

        public void prepararFormCrear()
        {
            this.Text = "Crear Actividad";
            this.labelActID.Visible = false;
            this.textBoxActID.Visible = false;
            this.buttonActModif.Visible = false;
            this.buttonActAceptar.Visible = false;
            this.labelActCom.Visible = false;
            this.listBoxActComisiones.Visible = false;
            this.buttonActCrear.Visible = true;
            this.buttonActCrear.Enabled = false;
        }

        public void prepararFormModificar()
        {
            this.Text = "Modificar Actividad";
            this.textBoxActID.Enabled = false;
            this.textBoxActID.ReadOnly = true;
            this.buttonActAceptar.Visible = false;
            this.buttonActCrear.Visible = false;
            this.labelActCom.Visible = false;
            this.listBoxActComisiones.Visible = false;
            this.buttonActModif.Visible = true;
            this.buttonActModif.Enabled = false;
        }

        public void prepararFormMostrar()
        {
            this.Text = "Actividad";
            this.textBoxActID.Enabled = false;
            this.textBoxActID.ReadOnly = true;
            this.textBoxActDesc.ReadOnly = true;
            this.textBoxActCosto.ReadOnly = true;
            this.buttonActAceptar.Visible = true;
            this.buttonActCrear.Visible = false;
            this.buttonActModif.Visible = false;
            this.listBoxActComisiones.Enabled = false;
        }

        private void textBoxActID_Validating(object sender, CancelEventArgs e)
        {
            string dni = textBoxActID.Text;

            string errorMsg;
            if (!validID(dni, out errorMsg))
            {
                e.Cancel = true;
                textBoxActID.Focus();

                this.errorProvider.SetError(textBoxActID, errorMsg);
            }
        }

        private void textBoxActID_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxActID, String.Empty);
        }

        private bool validID(string id, out string errorMessage)
        {
            if (id.Length < 1)
            {
                errorMessage = "El ID debe tener por lo menos 1 digitos.";
                return false;
            }
            else if (id.Length > 4)
            {
                errorMessage = "El ID debe ser de 4 dígitos máximo.";
                return false;
            }

            // Chequeamos con una regex que es un entero.
            if (System.Text.RegularExpressions.Regex.IsMatch(id, "^[0-9]+$"))
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "El ID debe estar en un formato válido.\n" + "Por ejemplo: '1234' ";
            return false;
        }

        private void textBoxActDesc_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxActDesc, String.Empty);
        }

        private void textBoxActDesc_Validating(object sender, CancelEventArgs e)
        {
            string desc = textBoxActDesc.Text;

            string errorMsg;
            if (!validDescripcion(desc, out errorMsg))
            {
                e.Cancel = true;
                textBoxActDesc.Focus();

                this.errorProvider.SetError(textBoxActDesc, errorMsg);
            }
        }

        private bool validDescripcion(string desc, out string errorMessage)
        {
            if (desc.Length == 0)
            {
                errorMessage = "La descripcion debe ser ingresada";
                return false;
            }

            if (desc.Length < 25)
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "La descripcion debe ser de 25 caracteres máximo.";
            return false;
        }

        private void textBoxActCosto_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxActCosto, String.Empty);
        }

        private void textBoxActCosto_Validating(object sender, CancelEventArgs e)
        {
            string costo = textBoxActCosto.Text;

            string errorMsg;
            if (!validCosto(costo, out errorMsg))
            {
                e.Cancel = true;
                textBoxActCosto.Focus();

                this.errorProvider.SetError(textBoxActCosto, errorMsg);
            }
        }

        private bool validCosto(string costo, out string errorMessage)
        {
            if (costo.Length > 8)
            {
                errorMessage = "El costo debe ser de 8 dígitos máximo.";
                return false;
            }

            // Chequeamos con una regex que es un entero.
            if (System.Text.RegularExpressions.Regex.IsMatch(costo, "^[0-9]+$"))
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "El costo debe estar en un formato válido.\n" + "Por ejemplo: '500' ";
            return false;
        }

        private void textBoxActID_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void textBoxActDesc_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void textBoxActCosto_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void listBoxActComisiones_Format(object sender, ListControlConvertEventArgs e)
        {
            string act = ((Comision)e.ListItem).Actividad.Descripcion;
            string id = ((Comision)e.ListItem).Id.ToString();
            string dia = ((Comision)e.ListItem).Dia;
            string horario = ((Comision)e.ListItem).Horario.ToString();

            e.Value = act + " | ID: " + id + " | Día: " + dia + " | Horario: " + horario + "hs";
        }
    }
}
