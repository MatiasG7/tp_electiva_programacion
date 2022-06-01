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
    public partial class FormComision : Form
    {
        private Comision com;

        public Comision Com { get => com; set => com = value; }

        // Form para Crear.
        public FormComision(List<Actividad> actividades, List<Profesor> profesores)
        {
            InitializeComponent();
            this.comboBoxComAct.DisplayMember = "Descripcion";
            this.comboBoxComAct.DataSource = actividades;
            this.comboBoxComProfesores.DisplayMember = "Nombre";
            this.comboBoxComProfesores.DataSource = profesores;
        }

        // Form para Modificar y Mostrar.
        public FormComision(Comision com, List<Profesor> profesores)
        {
            InitializeComponent();
            this.com = com;
            this.textBoxComID.Text = com.Id.ToString();
            this.textBoxComMaxPar.Text = com.CantidadMaximaParticipantes.ToString();
            this.comboBoxComProfesores.DataSource = profesores;
            this.listBoxComSocios.DataSource = com.Socios;
            this.listBoxComSocios.ClearSelected();
        }

        private void checkInputs()
        {
            string a;
            if (validID(textBoxComID.Text, out a) && validMaxPar(textBoxComMaxPar.Text, out a) &&
                comboBoxComAct.SelectedItem != null && comboBoxComDia.SelectedItem != null &&
                comboBoxComHorario.SelectedItem != null && comboBoxComProfesores.SelectedItem != null)
            {
                buttonComCrear.Enabled = true;
                buttonComModif.Enabled = true;
            }
            else
            {
                buttonComCrear.Enabled = false;
                buttonComModif.Enabled = false;
            }
        }

        private void buttonComCrear_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxComID.Text);
            Actividad act = (Actividad)this.comboBoxComAct.SelectedItem;
            string dia = this.comboBoxComDia.SelectedItem.ToString();
            int horario = int.Parse(this.comboBoxComHorario.SelectedItem.ToString());
            Profesor prof = (Profesor)this.comboBoxComProfesores.SelectedItem;
            int maxPar = int.Parse(this.textBoxComMaxPar.Text);

            int idCom = int.Parse(act.Id.ToString() + id.ToString());
            com = new Comision(idCom, act, dia, horario, prof, maxPar);

            act.agregarComision(com);

            prof.agregarComision(com);

            this.Close();
        }

        private void buttonComModif_Click(object sender, EventArgs e)
        {
            int dniProfesorViejo = com.Profesor.Dni;
            com.Profesor.removerComision(com);

            com.Dia = this.comboBoxComDia.SelectedItem.ToString();
            com.Horario = int.Parse(this.comboBoxComHorario.SelectedItem.ToString());
            com.Profesor = (Profesor)this.comboBoxComProfesores.SelectedItem;
            com.CantidadMaximaParticipantes = int.Parse(this.textBoxComMaxPar.Text);

            com.Profesor.agregarComision(com);

            com.modificarComDb(com);

            if (dniProfesorViejo != com.Profesor.Dni)
            {
                com.modificarProfesorDb(com);
            }

            this.Hide();
            MessageBox.Show("Comisión modificada satisfactoriamente.");
            this.Close();
        }

        private void buttonComAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonComCancelar_Click(object sender, EventArgs e)
        {
            com = null;

            this.Close();
        }

        public void prepararFormCrear()
        {
            this.Text = "Crear Comisión";
            this.textBoxComID.ReadOnly = false;
            this.buttonComModif.Visible = false;
            this.buttonComAceptar.Visible = false;
            this.labelComSocios.Visible = false;
            this.listBoxComSocios.Visible = false;
            this.buttonComCrear.Visible = true;
            this.buttonComCrear.Enabled = false;
        }

        public void prepararFormModificar()
        {
            this.Text = "Modificar Comisión";
            this.textBoxComID.ReadOnly = true;
            this.buttonComModif.Visible = true;
            this.buttonComModif.Enabled = false;
            this.buttonComAceptar.Visible = false;
            this.buttonComCrear.Visible = false;
            this.labelComSocios.Visible = false;
            this.listBoxComSocios.Visible = false;
            this.comboBoxComAct.Enabled = false;
            this.comboBoxComAct.Items.Add(com.Actividad.Descripcion);
            this.comboBoxComAct.SelectedIndex = comboBoxComAct.FindStringExact(com.Actividad.Descripcion);
            this.comboBoxComDia.SelectedIndex = comboBoxComDia.FindStringExact(com.Dia);
            this.comboBoxComHorario.SelectedIndex = comboBoxComHorario.FindStringExact(com.Horario.ToString());
            this.comboBoxComProfesores.SelectedIndex = comboBoxComProfesores.FindString(com.Profesor.Dni.ToString());
        }

        public void prepararFormMostrar()
        {
            this.Text = "Comisión";
            this.textBoxComID.ReadOnly = true;
            this.comboBoxComDia.Enabled = false;
            this.textBoxComMaxPar.ReadOnly = true;
            this.buttonComAceptar.Visible = true;
            this.buttonComModif.Visible = false;
            this.buttonComCrear.Visible = false;
            this.listBoxComSocios.Enabled = false;
            this.comboBoxComProfesores.Enabled = false;
            this.comboBoxComAct.Enabled = false;
            this.comboBoxComAct.Items.Add(com.Actividad.Descripcion);
            this.comboBoxComAct.SelectedIndex = comboBoxComAct.FindStringExact(com.Actividad.Descripcion);
            this.comboBoxComDia.SelectedIndex = comboBoxComDia.FindStringExact(com.Dia); //Selecciona el index del combox que es igual al string dado
            this.comboBoxComHorario.SelectedIndex = comboBoxComHorario.FindStringExact(com.Horario.ToString());
            this.comboBoxComProfesores.SelectedIndex = comboBoxComProfesores.FindString(com.Profesor.Dni.ToString()); //Busca hasta encontrar un string que empieze con el string dado (dni en este caso)
            this.comboBoxComDia.Enabled = false;
            this.comboBoxComHorario.Enabled = false;
            this.comboBoxComProfesores.Enabled = false;
        }

        private void textBoxComID_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void textBoxComMaxPar_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void textBoxComID_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxComID, String.Empty);
        }

        private void textBoxComID_Validating(object sender, CancelEventArgs e)
        {
            string id = textBoxComID.Text;

            string errorMsg;
            if (!validID(id, out errorMsg))
            {
                e.Cancel = true;
                textBoxComID.Focus();

                this.errorProvider.SetError(textBoxComID, errorMsg);
            }
        }

        private bool validID(string id, out string errorMessage)
        {
            if (id.Length < 1)
            {
                errorMessage = "El ID debe tener por lo menos 2 digitos.";
                return false;
            }
            else if (id.Length > 2 && !buttonComModif.Visible)
            {
                errorMessage = "El ID debe ser de 3 dígitos máximo.";
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

        private void textBoxComMaxPar_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxComMaxPar, String.Empty);
        }

        private void textBoxComMaxPar_Validating(object sender, CancelEventArgs e)
        {
            string par = textBoxComMaxPar.Text;

            string errorMsg;
            if (!validMaxPar(par, out errorMsg))
            {
                e.Cancel = true;
                textBoxComMaxPar.Focus();

                this.errorProvider.SetError(textBoxComMaxPar, errorMsg);
            }
        }

        private bool validMaxPar(string maxPar, out string errorMessage)
        {
            if (maxPar.Length > 3)
            {
                errorMessage = "La cantidad de participantes debe ser de 3 dígitos máximo.";
                return false;
            }

            // Chequeamos con una regex que es un entero.
            if (System.Text.RegularExpressions.Regex.IsMatch(maxPar, "^[0-9]+$"))
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "La cantidad de participantes debe estar en un formato válido.\n" + "Por ejemplo: '500' ";
            return false;
        }

        private void comboBoxComAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void comboBoxComDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void comboBoxComHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void comboBoxComProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void listBoxComSocios_Format(object sender, ListControlConvertEventArgs e)
        {
            string dni = ((Socio)e.ListItem).Dni.ToString();
            string nombre = ((Socio)e.ListItem).Nombre;
            string fnac = ((Socio)e.ListItem).FNac.ToString("dd/MM/yyyy");

            e.Value = "DNI: " + dni + " | Nombre: " + nombre + " | Fecha Nacimiento: " + fnac;
        }
    }
}
