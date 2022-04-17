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
            club = Club.Recuperar();
            listBoxAct.DataSource = club.Actividades;
            listBoxAct.ClearSelected();
            listBoxProf.DataSource = club.Profesores;
            listBoxProf.ClearSelected();
            listBoxSocios.DataSource = club.Socios;
            listBoxSocios.ClearSelected();
            listBoxCom.DataSource = club.Comisiones;
            listBoxCom.ClearSelected();
        }

        private void buttonCrearActividad_Click(object sender, EventArgs e)
        {
            FormActividad fa = new FormActividad(club.Profesores);
            fa.prepararFormCrear();
            fa.ShowDialog();

            Actividad act = fa.Act;
            if (act != null)
            {
                bool exists = club.verificarActividad(act);
                if (exists)
                {
                    MessageBox.Show("Ya existe una actividad con el ID ingresado.");
                }
                else
                {
                    club.agregarActividad(act);
                    MessageBox.Show("Actividad creada satisfactoriamente.");
                    listBoxAct.DataSource = null;
                    listBoxAct.DataSource = club.Actividades;
                    listBoxAct.ClearSelected();
                }
            }
        }

        private void buttonModificarActividad_Click(object sender, EventArgs e)
        {
            Actividad a = (Actividad)listBoxAct.SelectedItem;
            if (a == null)
                MessageBox.Show("No hay actividad seleccionada para modificar.");
            else
            {
                FormActividad fa = new FormActividad(a, club.Profesores);
                fa.prepararFormModificar();
                fa.ShowDialog();
                listBoxAct.DataSource = null;
                listBoxAct.DataSource = club.Actividades;
                listBoxAct.ClearSelected();
            }
        }

        private void buttonEliminarActividad_Click(object sender, EventArgs e)
        {
            Actividad a = (Actividad)listBoxAct.SelectedItem;
            if (a == null)
                MessageBox.Show("No hay actividad seleccionada para eliminar.");
            else
            {
                // Cuando se elimina la actividad se debería borrar las comisiones de ellas en las que esten socios inscriptos. Y profesores.
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar la actividad seleccionada?", "Eliminar Actividad", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    a.eliminar();
                    club.removerActividad(a);
                    listBoxAct.DataSource = null;
                    listBoxAct.DataSource = club.Actividades;
                    listBoxCom.DataSource = null;
                    listBoxCom.DataSource = club.Comisiones;
                }

                listBoxAct.ClearSelected();
            }
        }

        private void buttonMostrarActividad_Click(object sender, EventArgs e)
        {
            Actividad a = (Actividad)listBoxAct.SelectedItem;
            if (a == null)
                MessageBox.Show("No hay actividad seleccionada para mostrar.");
            else
            {
                FormActividad fa = new FormActividad((Actividad)listBoxAct.SelectedItem, club.Profesores);
                fa.prepararFormMostrar();
                fa.ShowDialog();
                listBoxAct.ClearSelected();
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea realizar un guardado ?", "Guardar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (club.guardar())
                    MessageBox.Show("GUARDADO OK");
                else
                    MessageBox.Show("ERROR AL GUARDAR");
            }

        }

        private void buttonCrearProf_Click(object sender, EventArgs e)
        {
            FormProfesor fp = new FormProfesor();
            fp.prepararFormCrear();
            fp.ShowDialog();

            Profesor prof = fp.Prof;
            if (prof != null)
            {
                bool exists = club.verificarProfesor(prof);
                if (exists)
                {
                    MessageBox.Show("Ya existe un profesor con el DNI ingresado.");
                }
                else
                {
                    club.agregarProfesor(prof);
                    MessageBox.Show("Profesor creado satisfactoriamente.");
                    listBoxProf.DataSource = null;
                    listBoxProf.DataSource = club.Profesores;
                    listBoxProf.ClearSelected();
                }
            }
        }

        private void buttonModifProf_Click(object sender, EventArgs e)
        {
            Profesor p = (Profesor)listBoxProf.SelectedItem;
            if (p == null)
                MessageBox.Show("No hay profesor seleccionado para modificar.");
            else
            {
                FormProfesor fp = new FormProfesor(p);
                fp.prepararFormModificar();
                fp.ShowDialog();
                listBoxProf.DataSource = null;
                listBoxProf.DataSource = club.Profesores;
                listBoxProf.ClearSelected();
            }
        }

        private void buttonElimProf_Click(object sender, EventArgs e)
        {
            Profesor p = (Profesor)listBoxProf.SelectedItem;
            if (p == null)
                MessageBox.Show("No hay profesor seleccionado para eliminar.");
            else
            {
                // Cuando se elimina el profesor se deberia borrar de las comisiones en las que estaba.
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar el profesor seleccionado?", "Eliminar Profesor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    club.removerProfesor(p);
                    listBoxProf.DataSource = null;
                    listBoxProf.DataSource = club.Profesores;
                }

                listBoxProf.ClearSelected();
            }
        }

        private void buttonMostrarProf_Click(object sender, EventArgs e)
        {
            Profesor p = (Profesor)listBoxProf.SelectedItem;
            if (p == null)
                MessageBox.Show("No hay profesor seleccionado para mostrar.");
            else
            {
                FormProfesor fp = new FormProfesor(p);
                fp.prepararFormMostrar();
                fp.ShowDialog();
                listBoxProf.ClearSelected();
            }
        }

        private void buttonCrearSocio_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Desea crear un tipo de Socio de Actividades ?", "Crear Socio", MessageBoxButtons.YesNoCancel);

            FormConfirmacion fc = new FormConfirmacion("Seleccionar tipo de socio", "Elija tipo de socio a crear", "Club", "Actividad", "Cancelar");
            fc.ShowDialog();

            if (fc.Option == 1 || fc.Option == 2)
            {
                FormSocio fs;
                if (fc.Option == 1)
                {
                    //Club
                    fs = new FormSocio(fc.Option);
                    fs.prepararFormCrearClub();
                }
                else
                {
                    //Actividad
                    fs = new FormSocio(fc.Option);
                    fs.prepararFormCrearActividad();
                }

                fs.ShowDialog();

                Socio sa = fs.Soc;
                if (sa != null)
                {
                    bool exists = club.verificarSocio(sa);
                    if (exists)
                    {
                        MessageBox.Show("Ya existe un socio con el DNI ingresado.");
                    }
                    else
                    {
                        club.agregarSocio(sa);
                        MessageBox.Show("Socio Actividad creado satisfactoriamente.");
                        listBoxSocios.DataSource = null;
                        listBoxSocios.DataSource = club.Socios;
                        listBoxSocios.ClearSelected();
                    }
                }
            }
        }

        private void buttonModifSocio_Click(object sender, EventArgs e)
        {
            Socio s = (Socio)listBoxSocios.SelectedItem;
            if (s == null)
                MessageBox.Show("No hay socio seleccionado para modificar.");
            else
            {
                FormSocio fs;
                if (s.GetType().Name == "SocioActividad")
                {
                    fs = new FormSocio((SocioActividad)s);
                    fs.prepararFormModificarActividad();
                    fs.ShowDialog();
                }
                else
                {
                    fs = new FormSocio((SocioClub)s);
                    fs.prepararFormModificarClub();
                    fs.ShowDialog();
                }

                listBoxSocios.DataSource = null;
                listBoxSocios.DataSource = club.Socios;
                listBoxSocios.ClearSelected();
            }
        }

        private void buttonElimSocio_Click(object sender, EventArgs e)
        {
            Socio s = (Socio)listBoxSocios.SelectedItem;
            if (s == null)
                MessageBox.Show("No hay socio seleccionado para eliminar.");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar el socio seleccionado?", "Eliminar Socio", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    club.removerSocio(s);
                    listBoxSocios.DataSource = null;
                    listBoxSocios.DataSource = club.Socios;
                }

                listBoxSocios.ClearSelected();
            }
        }

        private void buttonMostrarSocio_Click(object sender, EventArgs e)
        {
            Socio s = (Socio)listBoxSocios.SelectedItem;
            if (s == null)
                MessageBox.Show("No hay socio seleccionado para mostrar.");
            else
            {
                FormSocio fs;
                if (s.GetType().Name == "SocioActividad")
                {
                    fs = new FormSocio((SocioActividad)s);
                    fs.prepararFormMostrarActividad();
                    fs.ShowDialog();
                }
                else
                {
                    fs = new FormSocio((SocioClub)s);
                    fs.prepararFormMostrarClub();
                    fs.ShowDialog();
                }

                listBoxSocios.ClearSelected();
            }
        }

        private void buttonCrearComision_Click(object sender, EventArgs e)
        {
            FormComision fc = new FormComision(club.Actividades, club.Profesores);
            fc.prepararFormCrear();
            fc.ShowDialog();

            Comision com = fc.Com;
            if (com != null)
            {
                club.agregarComision(com);
                MessageBox.Show("Comisión creada satisfactoriamente.");
                listBoxCom.DataSource = null;
                listBoxCom.DataSource = club.Comisiones;
                listBoxCom.ClearSelected();
            }
        }

        private void buttonModifComision_Click(object sender, EventArgs e)
        {
            Comision c = (Comision)listBoxCom.SelectedItem;
            if (c == null)
                MessageBox.Show("No hay comisión seleccionada para modificar.");
            else
            {
                FormComision fc = new FormComision(c, club.Profesores);
                fc.prepararFormModificar();
                fc.ShowDialog();
                listBoxCom.DataSource = null;
                listBoxCom.DataSource = club.Comisiones;
                listBoxCom.ClearSelected();
            }
        }

        private void buttonElimCom_Click(object sender, EventArgs e)
        {
            Comision c = (Comision)listBoxCom.SelectedItem;
            if (c == null)
                MessageBox.Show("No hay comisión seleccionada para eliminar.");
            else
            {
                // Cuando se borra una comision se deberia borrar las inscripciones de socios a ellas?
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar la comisión seleccionada?", "Eliminar Comisión", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    c.eliminar();
                    club.removerComision(c);
                    listBoxCom.DataSource = null;
                    listBoxCom.DataSource = club.Comisiones;
                }

                listBoxCom.ClearSelected();
            }
        }

        private void buttonMostrarComision_Click(object sender, EventArgs e)
        {
            Comision c = (Comision)listBoxCom.SelectedItem;
            if (c == null)
                MessageBox.Show("No hay comisión seleccionada para mostrar.");
            else
            {
                FormComision fc = new FormComision(c, club.Profesores);
                fc.prepararFormMostrar();
                fc.ShowDialog();
                listBoxCom.ClearSelected();
            }
        }
    }
}

