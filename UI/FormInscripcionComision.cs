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

        // Para agregar
        public FormInscripcionComision(List<Actividad> act, Socio soc)
        {
            InitializeComponent();
            this.soc = soc;
            this.act = act;
            // Mostramos las actividades en las que el socio no esta inscripto y las que tienen comisiones creadas (pero que no superen el maximo de participantes permitidos).
            listBoxInsSocAct.DataSource = act.Except(soc.Comisiones.Select(x => x.Actividad)).Where(a => a.Comisiones.Count != 0 && a.Comisiones.Any(c => c.verificarCantParticipantes())).ToList();
        }

        // Para eliminar
        public FormInscripcionComision(Socio soc)
        {
            InitializeComponent();
            this.soc = soc;
            listBoxInsSocAct.DataSource = soc.Comisiones.Select(x => x.Actividad).ToList();
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
                com.agregarSocio(soc);
                soc.agregarComision(com);

                //DB: Agrego la relacion entre Socio y Comision, INSCRIPCION
                soc.agregarInscripcionDb(com);

                this.Hide();
                MessageBox.Show("Socio inscripto correctamente.");
                this.Close();
            }
        }

        private void listBoxInsSocAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actividad act = (Actividad)listBoxInsSocAct.SelectedItem;
            listBoxInsSocCom.DataSource = act.Comisiones.Except(soc.Comisiones.Select(x => x)).Where(a => a.verificarCantParticipantes()).ToList();
        }

        public void prepararInscripcionSocio()
        {
            Text = "Inscripcion a comision";
            buttonInsComElim.Visible = false;
            buttonInsConfirmar.Visible = true;
        }

        public void prepararEliminarSocio()
        {
            Text = "Eliminar socio de comision";
            listBoxInsSocCom.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            buttonInsComElim.Visible = true;
            buttonInsConfirmar.Visible = false;
        }

        private void buttonInsCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsComElim_Click(object sender, EventArgs e)
        {
            Actividad act = (Actividad)listBoxInsSocAct.SelectedItem;
            if (act == null)
            {
                MessageBox.Show("No hay actividad seleccionada para eliminar.");
            }
            else
            {
                Comision comSoc = soc.Comisiones.First(c => c.Actividad == act);

                comSoc.removerSocio(this.soc);

                // Removemos la comision del socio.
                // DB: Removemos la relacion entre Socio y Comision especificamente de este socio y esta comision.
                this.soc.removerComision(comSoc);

                this.Hide();
                MessageBox.Show("Socio eliminado de actividad correctamente.");
                this.Close();
            }
        }

        private void listBoxInsSocAct_Format(object sender, ListControlConvertEventArgs e)
        {
            string id = ((Actividad)e.ListItem).Id.ToString();
            string desc = ((Actividad)e.ListItem).Descripcion;
            string costo = ((Actividad)e.ListItem).Costo.ToString();

            e.Value = "ID: " + id + " | Descripción: " + desc + " | Costo: $" + costo;
        }

        private void listBoxInsSocCom_Format(object sender, ListControlConvertEventArgs e)
        {
            string act = ((Comision)e.ListItem).Actividad.Descripcion;
            string id = ((Comision)e.ListItem).Id.ToString();
            string dia = ((Comision)e.ListItem).Dia;
            string horario = ((Comision)e.ListItem).Horario.ToString();

            e.Value = act + " | ID: " + id + " | Día: " + dia + " | Horario: " + horario + "hs";
        }
    }
}
