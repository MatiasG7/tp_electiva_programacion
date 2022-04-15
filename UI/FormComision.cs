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

        public FormComision(Actividad act, List<Profesor> profesores)
        {
            InitializeComponent();
            this.act = act;
            this.labelComActividad2.Text = act.Descripcion;
            this.comboBoxComProfesores.DataSource = profesores;
        }

        public FormComision(Actividad act, Comision com, List<Profesor> profesores)
        {
            InitializeComponent();
            this.act = act;
            this.labelComActividad2.Text = act.Descripcion;
            this.textBoxComID.Text = com.Id.ToString();
            this.numericUpDownComHorario.Text = com.Horario.ToString();
            this.textBoxComProfesor.Text = com.Profesor.ToString();
            this.textBoxComMaxPar.Text = com.CantidadMaximaParticipantes.ToString();
            this.comboBoxComProfesores.DataSource = profesores;
            listBoxComSocios.DataSource = com.Socios;
            listBoxComSocios.ClearSelected();
        }

        private void buttonComCrear_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxComID.Text);
            string dia = this.comboBoxComDia.SelectedItem.ToString();
            int horario = int.Parse(this.textBoxComHorario.Text);
            string profesor = this.textBoxComProfesor.Text;             // Como acceder al nombre de la super clase persona?
            int maxPar = int.Parse(this.textBoxComMaxPar.Text);

            // Podemos usar un combobox para el profesor, que ya esten precargados los profesores que hay.
            Profesor prof = new Profesor(DateTime.Now, 30111222, profesor, DateTime.Now.AddDays(-30));

            com = new Comision(id, this.act, dia, horario, prof, maxPar);

            this.Close();
        }

        private void buttonComModif_Click(object sender, EventArgs e)
        {
            com.Dia = this.textBoxComID.Text;
            com.Horario = int.Parse(this.numericUpDownComHorario.Text);

            string profesor = this.textBoxComProfesor.Text;
            Profesor prof = new Profesor(DateTime.Now, 20222111, profesor, DateTime.Now.AddDays(-30));
            com.Profesor = prof;

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
            this.buttonComCrear.Visible = true;
        }

        public void prepararFormModificar()
        {
            this.Text = "Modificar Comisión";
            this.textBoxComID.ReadOnly = true;
            this.buttonComModif.Visible = true;
            this.buttonComAceptar.Visible = false;
            this.buttonComCrear.Visible = false;
            this.comboBoxComProfesores.SelectedItem = com.Profesor;
        }

        public void prepararFormMostrar()
        {
            this.Text = "Comisión";
            this.textBoxComID.ReadOnly = true;
            this.comboBoxComDia.Enabled = false;
            this.numericUpDownComHorario.ReadOnly = true;
            this.textBoxComProfesor.ReadOnly = true;
            this.textBoxComMaxPar.ReadOnly = true;
            this.buttonComAceptar.Visible = true;
            this.buttonComModif.Visible = false;
            this.buttonComCrear.Visible = false;
            this.comboBoxComProfesores.SelectedItem = com.Profesor;
        }
    }
}
