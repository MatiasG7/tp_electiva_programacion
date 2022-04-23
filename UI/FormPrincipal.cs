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
                MessageBox.Show("Actividad modificada satisfactoriamente.");
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
                    MessageBox.Show("Actividad eliminada satisfactoriamente.");
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
                MessageBox.Show("Profesor modificado satisfactoriamente.");
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
                if (p.Comisiones.Count() == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar el profesor seleccionado?", "Eliminar Profesor", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        club.removerProfesor(p);
                        MessageBox.Show("Profesor eliminado satisfactoriamente.");
                        listBoxProf.DataSource = null;
                        listBoxProf.DataSource = club.Profesores;
                    }
                }
                else
                {
                    // Cuando se elimina el profesor se deberia borrar de las comisiones en las que estaba.
                    DialogResult dialogResult = MessageBox.Show("Si elimina el profesor tambien estará eliminando la comision y todos sus datos ligados a ella. Esta seguro que desea eliminar el profesor seleccionado?", "Eliminar Profesor", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        p.limpiarComisiones();
                        club.removerProfesor(p);
                        MessageBox.Show("Profesor eliminado satisfactoriamente.");
                        listBoxProf.DataSource = null;
                        listBoxProf.DataSource = club.Profesores;
                    }
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

                Socio s = fs.Soc;
                if (s != null)
                {
                    bool exists = club.verificarSocio(s);
                    if (exists)
                    {
                        MessageBox.Show("Ya existe un socio con el DNI ingresado.");
                    }
                    else
                    {
                        club.agregarSocio(s);
                        MessageBox.Show("Socio creado satisfactoriamente.");
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

                MessageBox.Show("Socio modificado satisfactoriamente.");
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
                    MessageBox.Show("Socio eliminado satisfactoriamente.");
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
                if (club.verificarComision(com))
                {
                    MessageBox.Show("Ya existe una comisión en la actividad con el ID ingresado.");
                }
                else
                {
                    club.agregarComision(com);
                    MessageBox.Show("Comisión creada satisfactoriamente.");
                    listBoxCom.DataSource = null;
                    listBoxCom.DataSource = club.Comisiones;
                    listBoxCom.ClearSelected();
                }
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
                MessageBox.Show("Comisión modificada satisfactoriamente.");
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
                    MessageBox.Show("Comisión eliminada satisfactoriamente.");
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

        private void buttonInsSocAct_Click(object sender, EventArgs e)
        {
            Socio s = (Socio)listBoxSocios.SelectedItem;
            if (s == null)
                MessageBox.Show("No hay socio seleccionado para mostrar.");
            else
            {
                if (club.Comisiones.Count > 0)
                {
                    FormInscripcionComision fic = new FormInscripcionComision(club.Actividades, s);
                    fic.prepararInscripcionSocio();
                    fic.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe tener comisiones para inscribir un socio.");
                }

                listBoxSocios.ClearSelected();
            }
        }

        private void buttonElimSocAct_Click(object sender, EventArgs e)
        {
            Socio s = (Socio)listBoxSocios.SelectedItem;
            if (s == null)
                MessageBox.Show("No hay socio seleccionado para mostrar.");
            else
            {
                if (club.Comisiones.Count > 0)
                {
                    if (s.Comisiones.Count > 0)
                    {
                        FormInscripcionComision fic = new FormInscripcionComision(s);
                        fic.prepararEliminarSocio();
                        fic.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("El socio no esta inscripto a ninguna actividad.");
                    }

                }
                else
                {
                    MessageBox.Show("Debe tener comisiones para eliminar un socio de una comision.");
                }

                listBoxSocios.ClearSelected();
            }
        }

        // REVISAR, NO FUNKA DE UNA
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 2:
                    {
                        if (club.Comisiones.Count < 1)
                        {
                            buttonInsSocAct.Enabled = false;
                            buttonElimSocAct.Enabled = false;
                            buttonRegPagoSoc.Enabled = false;
                        }
                        break;
                    }
            }
        }

        private void listBoxSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Socio s = (Socio)listBoxSocios.SelectedItem;
            if (s != null)
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.buttonElimSocAct, "El socio no esta inscripto en ninguna comisión.");
                if (s.Comisiones.Count < 1)
                {
                    buttonElimSocAct.Enabled = false;
                    tt.Active = true;
                }
                else
                {
                    buttonElimSocAct.Enabled = true;
                    tt.Active = false;
                }

                tt.SetToolTip(this.buttonRegPagoSoc, "El pago ya esta realizado para este mes.");
                if (club.verificarPago(s))
                {
                    buttonRegPagoSoc.Enabled = false;
                    tt.Active = true;
                }
                else
                {
                    buttonRegPagoSoc.Enabled = true;
                    tt.Active = false;
                }
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            int defaultCant = 5;
            string cant = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor para la cantidad maxima de actividades del socio club.", "Cantidad Maxima Actividades", defaultCant.ToString());
            if (cant.Length != 0)
            {
                defaultCant = int.Parse(cant);
            }
            SocioClub.SetMaxCantActividades(defaultCant);

            int defaultDesc = 50;
            string desc = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor para el porcentaje de descuentos del socio club.", "Porcentaje Descuento", defaultDesc.ToString());
            if (desc.Length != 0)
            {
                defaultDesc = int.Parse(desc);
            }
            SocioClub.SetPorcentajeDescuento(defaultDesc);
        }

        private void buttonRegPagoSoc_Click(object sender, EventArgs e)
        {
            Socio s = (Socio)listBoxSocios.SelectedItem;
            if (s == null)
                MessageBox.Show("No hay socio seleccionado para registrar un pago.");
            else
            {
                double monto = s.calcularMontoAPagar();
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea realizar el pago correspondiente a $" + monto + " para el mes corriente ?", "Realizar Pago", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Pago p = new Pago(club.calcularIDPago(), s, monto);
                    club.agregarPago(p);
                }

                listBoxSocios.ClearSelected();
            }
        }
    }
}

