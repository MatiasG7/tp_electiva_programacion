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
            this.comboBoxComAct.DataSource = actividades;
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
            com.Profesor.removerComision(com);

            com.Dia = this.comboBoxComDia.SelectedItem.ToString();
            com.Horario = int.Parse(this.comboBoxComHorario.SelectedItem.ToString());
            com.Profesor = (Profesor)this.comboBoxComProfesores.SelectedItem;
            com.CantidadMaximaParticipantes = int.Parse(this.textBoxComMaxPar.Text);

            com.Profesor.agregarComision(com);

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
        }

        public void prepararFormModificar()
        {
            this.Text = "Modificar Comisión";
            this.textBoxComID.ReadOnly = true;
            this.buttonComModif.Visible = true;
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
    }
}
