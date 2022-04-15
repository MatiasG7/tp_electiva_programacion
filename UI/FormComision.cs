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
        private Actividad act;
        private Comision com;
        private List<Profesor> profesores;

        public Comision Com { get => com; set => com = value; }

        // Form para Crear.
        public FormComision(Actividad act, List<Profesor> profesores)
        {
            InitializeComponent();
            this.act = act;
            this.labelComActividad2.Text = act.Descripcion;
            this.comboBoxComProfesores.DataSource = profesores;
        }

        // Form para Modificar y Mostrar.
        public FormComision(Actividad act, Comision com, List<Profesor> profesores)
        {
            InitializeComponent();
            this.act = act;
            this.labelComActividad2.Text = act.Descripcion;
            this.textBoxComID.Text = com.Id.ToString();
            this.textBoxComMaxPar.Text = com.CantidadMaximaParticipantes.ToString();
            this.comboBoxComProfesores.DataSource = profesores;
            this.listBoxComSocios.DataSource = com.Socios;
            this.listBoxComSocios.ClearSelected();
        }

        private void buttonComCrear_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxComID.Text);
            string dia = this.comboBoxComDia.SelectedItem.ToString();
            int horario = int.Parse(this.comboBoxComHorario.Text);
            Profesor p = (Profesor)this.comboBoxComProfesores.SelectedItem;
            int maxPar = int.Parse(this.textBoxComMaxPar.Text);

            com = new Comision(id, this.act, dia, horario, p, maxPar);

            this.Close();
        }

        private void buttonComModif_Click(object sender, EventArgs e)
        {
            com.Dia = this.textBoxComID.Text;
            com.Horario = int.Parse(this.comboBoxComHorario.Text);
            com.Profesor = (Profesor)this.comboBoxComProfesores.SelectedItem;
            com.CantidadMaximaParticipantes = int.Parse(this.textBoxComMaxPar.Text);

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
            this.comboBoxComDia.SelectedItem = com.Dia;
            this.comboBoxComHorario.SelectedItem = com.Horario;
            this.comboBoxComProfesores.SelectedItem = com.Profesor;
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
            this.comboBoxComDia.SelectedItem = com.Dia;
            this.comboBoxComHorario.SelectedItem = com.Horario;
            this.comboBoxComProfesores.SelectedItem = com.Profesor;
            this.comboBoxComDia.Enabled = false;
            this.comboBoxComHorario.Enabled = false;
            this.comboBoxComProfesores.Enabled = false;
        }
    }
}
