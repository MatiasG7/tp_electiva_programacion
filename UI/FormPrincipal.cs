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
    public partial class FormPrincipal : Form
    {
        private Club club;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonCrearActividad_Click(object sender, EventArgs e)
        {
            FormActividad fca = new FormActividad();
            fca.prepararFormCrear();
            fca.ShowDialog();

            Actividad act = fca.Act;

            bool exists = club.verificarActividad(act);
            if (exists)
            {
                MessageBox.Show("Esta actividad ya existe.");
            }
            else
            {
                MessageBox.Show("Actividad creada satisfactoriamente.");
                listBoxAct.DataSource = null;
                listBoxAct.DataSource = club.Actividades;
                listBoxAct.ClearSelected();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonModificarActividad_Click(object sender, EventArgs e)
        {
            FormActividad fca = new FormActividad((Actividad)listBoxAct.SelectedItem);
            fca.prepararFormModificar();
            fca.ShowDialog();
        }

        private void buttonMostrarActividad_Click(object sender, EventArgs e)
        {
            Actividad a;
            a = (Actividad)listBoxAct.SelectedItem;
            if (a == null)
                MessageBox.Show("No hay actividad seleccionada para mostrar.");
            else
            {
                FormActividad fca = new FormActividad((Actividad)listBoxAct.SelectedItem);
                fca.prepararFormMostrar();
                fca.ShowDialog();
            }
        }

        private void buttonEliminarActividad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar la actividad seleccionada?", "Eliminar Actividad", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                club.removerActividad((Actividad)listBoxAct.SelectedItem);
            }
        }
    }
}
