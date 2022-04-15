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
        public FormProfesor()
        {
            InitializeComponent();
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
            this.buttonProfCrear.Visible = true;
        }

        public void prepararFormModificar()
        {
            this.Text = "Modificar Profesor";
            this.textBoxProfDNI.ReadOnly = true;
            this.buttonProfModif.Visible = true;
            this.buttonProfAceptar.Visible = false;
            this.buttonProfCrear.Visible = false;
        }

        public void prepararFormMostrar()
        {
            this.Text = "Profesor";
            this.textBoxProfDNI.ReadOnly = true;
            this.textBoxProfNombre.ReadOnly = true;
            this.buttonProfAceptar.Visible = true;
            this.dateTimePickerProfFNac.Enabled = false;
            this.dateTimePickerProfFIng.Enabled = false;
            this.buttonProfCrear.Visible = false;
            this.buttonProfModif.Visible = false;
        }
    }
}
