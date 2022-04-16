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
    public partial class FormSocioClub : Form
    {
        private SocioClub soc;

        public SocioClub Soc { get => soc; set => soc = value; }

        public FormSocioClub()
        {
            InitializeComponent();
        }

        public FormSocioClub(SocioClub s)
        {
            InitializeComponent();
            this.soc = s;
            this.textBoxSocDNI.Text = s.Dni.ToString();
            this.textBoxSocNombre.Text = s.Nombre;
            this.textBoxSocEmail.Text = s.Email;
            this.textBoxSocCuotaSocial.Text = s.CuotaSocial.ToString();
            this.textBoxSocDireccion.Text = s.Direccion;
            this.dateTimePickerSocFIng.Value = s.FIng;
            this.dateTimePickerSocFNac.Value = s.FNac;
        }

        private void buttonSocCrear_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(this.textBoxSocDNI.Text);
            string nombre = this.textBoxSocNombre.Text;
            DateTime fnac = this.dateTimePickerSocFNac.Value;
            string email = this.textBoxSocEmail.Text;
            string direccion = this.textBoxSocDireccion.Text;
            DateTime fing = this.dateTimePickerSocFIng.Value;
            double cuotaSocial = double.Parse(this.textBoxSocCuotaSocial.Text);

            this.soc = new SocioClub(cuotaSocial, email, direccion, fing, dni, nombre, fnac);

            this.Close();
        }

        private void buttonSocModif_Click(object sender, EventArgs e)
        {
            soc.Nombre = this.textBoxSocNombre.Text;
            soc.FNac = this.dateTimePickerSocFNac.Value;
            soc.Email = this.textBoxSocEmail.Text;
            soc.Direccion = this.textBoxSocDireccion.Text;
            soc.FIng = this.dateTimePickerSocFIng.Value;
            soc.CuotaSocial = double.Parse(this.textBoxSocCuotaSocial.Text);

            this.Close();
        }

        private void buttonSocAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSocCancelar_Click(object sender, EventArgs e)
        {
            soc = null;

            this.Close();
        }

        public void prepararFormCrear()
        {
            this.Text = "Crear Socio Club";
            this.textBoxSocDNI.ReadOnly = false;
            this.buttonSocModif.Visible = false;
            this.buttonSocAceptar.Visible = false;
            this.listBoxSocComisiones.Visible = false;
            this.buttonSocCrear.Visible = true;
        }

        public void prepararFormModificar()
        {
            this.Text = "Modificar Socio Club";
            this.textBoxSocDNI.ReadOnly = true;
            this.buttonSocModif.Visible = true;
            this.buttonSocAceptar.Visible = false;
            this.buttonSocCrear.Visible = false;
            this.listBoxSocComisiones.Visible = false;
        }

        public void prepararFormMostrar()
        {
            this.Text = "Socio Club";
            this.textBoxSocDNI.ReadOnly = true;
            this.textBoxSocNombre.ReadOnly = true;
            this.textBoxSocEmail.ReadOnly = true;
            this.textBoxSocDireccion.ReadOnly = true;
            this.textBoxSocCuotaSocial.ReadOnly = true;
            this.buttonSocAceptar.Visible = true;
            this.dateTimePickerSocFNac.Enabled = false;
            this.dateTimePickerSocFIng.Enabled = false;
            this.buttonSocCrear.Visible = false;
            this.buttonSocModif.Visible = false;
        }
    }
}
