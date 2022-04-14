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

        public Actividad Act { get => act; set => act = value; }

        public FormActividad()
        {
            InitializeComponent();
        }

        public FormActividad(Actividad act)
        {
            InitializeComponent();
            this.act = act;
        }

        private void FormCrearActividad_Load(object sender, EventArgs e)
        {

        }

        private void buttonActCrear_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxActID.Text);
            string desc = this.textBoxActDesc.Text;
            double costo = double.Parse(this.textBoxActCosto.Text);

            act = new Actividad(id, desc, costo);

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
            this.textBoxActID.ReadOnly = false;
            this.buttonActModif.Visible = false;
            this.buttonActCrear.Visible = true;
        }

        public void prepararFormModificar()
        {
            this.Text = "Modificar Actividad";
            this.textBoxActID.ReadOnly = true;
            this.buttonActModif.Visible = true;
            this.buttonActCrear.Visible = false;
        }

        public void prepararFormMostrar()
        {
            this.Text = "Actividad";
            this.textBoxActID.ReadOnly = true;
            this.textBoxActDesc.ReadOnly = true;
            this.textBoxActCosto.ReadOnly = true;
            this.buttonActAceptar.Visible = true;
            this.buttonActCrear.Visible = false;
            this.buttonActModif.Visible = false;
        }

        private void buttonActModif_Click(object sender, EventArgs e)
        {
            act.Descripcion = this.textBoxActDesc.Text;
            act.Costo = double.Parse(this.textBoxActCosto.Text);

            this.Close();
        }
    }
}
