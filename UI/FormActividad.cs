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
        }

        private void FormCrearActividad_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelActID;
        }

        private void buttonActCrear_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxActID.Text);
            string desc = this.textBoxActDesc.Text;
            double costo = double.Parse(this.textBoxActCosto.Text);

            act = new Actividad(id, desc, costo);

            this.Close();
        }

        private void buttonActModif_Click(object sender, EventArgs e)
        {
            act.Descripcion = this.textBoxActDesc.Text;
            act.Costo = double.Parse(this.textBoxActCosto.Text);

            this.Close();
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
            this.textBoxActID.ReadOnly = false;
            this.buttonActModif.Visible = false;
            this.buttonActAceptar.Visible = false;
            this.buttonActCrear.Visible = true;
        }

        public void prepararFormModificar()
        {
            this.Text = "Modificar Actividad";
            this.textBoxActID.ReadOnly = true;
            this.buttonActModif.Visible = true;
            this.buttonActAceptar.Visible = false;
            this.buttonActCrear.Visible = false;
            this.listBoxActComisiones.DataSource = act.Comisiones;
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
            this.listBoxActComisiones.DataSource = act.Comisiones;
        }

        private void buttonComCrear_Click(object sender, EventArgs e)
        {
            FormComision fc = new FormComision(act, this.profesores);
            fc.prepararFormCrear();
            fc.ShowDialog();

            Comision com = fc.Com;
            if (com != null)
            {
                bool exists = act.verificarComision(com);
                if (exists)
                {
                    MessageBox.Show("Ya existe una comisión con el ID ingresado.");
                }
                else
                {
                    MessageBox.Show("Comisión creada satisfactoriamente.");
                    listBoxActComisiones.DataSource = null;
                    listBoxActComisiones.DataSource = act.Comisiones;
                    listBoxActComisiones.ClearSelected();
                }
            }
        }

        private void buttonComModif_Click(object sender, EventArgs e)
        {
            Comision c = (Comision)listBoxActComisiones.SelectedItem;
            if (c == null)
                MessageBox.Show("No hay comisión seleccionada para modificar.");
            else
            {
                FormComision fc = new FormComision(act, c, this.profesores);
                fc.prepararFormModificar();
                fc.ShowDialog();
                listBoxActComisiones.DataSource = null;
                listBoxActComisiones.DataSource = act.Comisiones;
                listBoxActComisiones.ClearSelected();
            }
        }

        private void buttonComElim_Click(object sender, EventArgs e)
        {
            Comision c = (Comision)listBoxActComisiones.SelectedItem;
            if (c == null)
                MessageBox.Show("No hay comisión seleccionada para eliminar.");
            else
            {
                // Cuando se borra una comision se deberia borrar las inscripciones de socios a ellas?
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar la comisión seleccionada?", "Eliminar Comisión", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    act.removerComision(c);
                    listBoxActComisiones.DataSource = null;
                    listBoxActComisiones.DataSource = act.Comisiones;
                }

                listBoxActComisiones.ClearSelected();
            }
        }

        private void buttonComMostrar_Click(object sender, EventArgs e)
        {
            Comision c = (Comision)listBoxActComisiones.SelectedItem;
            if (c == null)
                MessageBox.Show("No hay comisión seleccionada para mostrar.");
            else
            {
                FormComision fc = new FormComision(this.act, (Comision)listBoxActComisiones.SelectedItem, null);
                fc.prepararFormMostrar();
                fc.ShowDialog();
                listBoxActComisiones.ClearSelected();
            }
        }
    }
}
