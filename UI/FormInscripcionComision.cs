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
    public partial class FormInscripcionComision : Form
    {
        Socio soc;
        List<Actividad> act;

        public FormInscripcionComision(List<Actividad> act, Socio soc)
        {
            InitializeComponent();
            this.soc = soc;
            this.act = act;
            listBoxInsSocAct.DataSource = act;
        }

        private void buttonInsConfirmar_Click(object sender, EventArgs e)
        {
            Comision com = (Comision)listBoxInsSocCom.SelectedItem;
            if (com == null)
            {
                MessageBox.Show("Seleccione comision para avanzar.");
            }
            else
            {
                if (com.verificarSocio(soc) == false)
                {
                    com.agregarSocio(soc);
                    soc.agregarComision(com);
                }
                else
                {
                    MessageBox.Show("Socio ya se encuentra inscripto a esta comision.");
                }

                this.Close();
            }

        }

        private void listBoxInsSocAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actividad act = (Actividad)listBoxInsSocAct.SelectedItem;
            listBoxInsSocCom.DataSource = act.Comisiones;
        }

        public void prepararInscripcionSocio()
        {
            Text = "Inscripcion a comision";
        }

        public void prepararEliminarSocio()
        {
            Text = "Eliminar socio de comision";
        }

        private void buttonInsCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
