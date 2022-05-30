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
    public partial class FormSocio : Form
    {
        int option = 0; // 1 - Club | 2 - Actividad
        private Socio soc;
        private SocioActividad socAct;
        private SocioClub socClub;
        private double? cuotaSocial = null;

        public Socio Soc { get => soc; set => soc = value; }
        public double CuotaSocial { get => cuotaSocial.Value; set => cuotaSocial = value; }

        public FormSocio(int i)
        {
            InitializeComponent();
            this.option = i;
        }

        public FormSocio(SocioClub socClub)
        {
            InitializeComponent();
            this.socClub = socClub;
            this.textBoxSocDNI.Text = socClub.Dni.ToString();
            this.textBoxSocNombre.Text = socClub.Nombre;
            this.textBoxSocEmail.Text = socClub.Email;
            this.textBoxSocCuotaSocial.Text = socClub.CuotaSocial.ToString();
            this.textBoxSocDireccion.Text = socClub.Direccion;
            this.dateTimePickerSocFIng.Value = socClub.FIng;
            this.dateTimePickerSocFNac.Value = socClub.FNac;
            this.listBoxSocComisiones.DataSource = socClub.Comisiones;
            this.listBoxSocComisiones.ClearSelected();
        }

        public FormSocio(SocioActividad socAct)
        {
            InitializeComponent();
            this.socAct = socAct;
            this.textBoxSocDNI.Text = socAct.Dni.ToString();
            this.textBoxSocNombre.Text = socAct.Nombre;
            this.textBoxSocEmail.Text = socAct.Email;
            this.textBoxSocDireccion.Text = socAct.Direccion;
            this.dateTimePickerSocFIng.Value = socAct.FIng;
            this.dateTimePickerSocFNac.Value = socAct.FNac;
            this.listBoxSocComisiones.DataSource = socAct.Comisiones;
            this.listBoxSocComisiones.ClearSelected();
        }

        private void checkInputs()
        {
            string a;
            if (validDni(textBoxSocDNI.Text, out a) && validNombre(textBoxSocNombre.Text, out a) &&
                validEmailAddress(textBoxSocEmail.Text, out a) && validDireccion(textBoxSocDireccion.Text, out a))
            {
                if (textBoxSocCuotaSocial.Visible)
                {
                    if (validCuotaSocial(textBoxSocCuotaSocial.Text, out a))
                    {
                        buttonSocCrear.Enabled = true;
                        buttonSocModif.Enabled = true;
                    }
                    else
                    {
                        buttonSocCrear.Enabled = false;
                        buttonSocModif.Enabled = false;
                    }
                }
                else
                {
                    buttonSocCrear.Enabled = true;
                    buttonSocModif.Enabled = true;
                }
            }
            else
            {
                buttonSocCrear.Enabled = false;
                buttonSocModif.Enabled = false;
            }
        }

        private void buttonSocCrear_Click_1(object sender, EventArgs e)
        {
            int dni = int.Parse(this.textBoxSocDNI.Text);
            string nombre = this.textBoxSocNombre.Text;
            DateTime fnac = this.dateTimePickerSocFNac.Value;
            string email = this.textBoxSocEmail.Text;
            string direccion = this.textBoxSocDireccion.Text;
            DateTime fing = this.dateTimePickerSocFIng.Value;

            if (option == 1)
            {
                double cuotaSocial = double.Parse(this.textBoxSocCuotaSocial.Text);
                this.soc = new SocioClub(cuotaSocial, email, direccion, fing, dni, nombre, fnac);
                this.cuotaSocial = cuotaSocial;
            }
            else if (option == 2)
            {
                this.soc = new SocioActividad(email, direccion, fing, dni, nombre, fnac);
            }
            this.Close();
        }

        private void buttonSocModif_Click_1(object sender, EventArgs e)
        {
            if (socAct != null)
            {
                socAct.Nombre = this.textBoxSocNombre.Text;
                socAct.FNac = this.dateTimePickerSocFNac.Value;
                socAct.Email = this.textBoxSocEmail.Text;
                socAct.Direccion = this.textBoxSocDireccion.Text;
                socAct.FIng = this.dateTimePickerSocFIng.Value;
            }
            else if (socClub != null)
            {
                socClub.Nombre = this.textBoxSocNombre.Text;
                socClub.FNac = this.dateTimePickerSocFNac.Value;
                socClub.Email = this.textBoxSocEmail.Text;
                socClub.Direccion = this.textBoxSocDireccion.Text;
                socClub.FIng = this.dateTimePickerSocFIng.Value;
                socClub.CuotaSocial = double.Parse(this.textBoxSocCuotaSocial.Text);
            }

            this.Hide();
            MessageBox.Show("Socio modificado satisfactoriamente.");
            this.Close();
        }

        private void buttonSocAceptar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSocCancelar_Click_1(object sender, EventArgs e)
        {
            soc = null;

            this.Close();
        }

        public void prepararFormCrear()
        {
            this.textBoxSocDNI.ReadOnly = false;
            this.buttonSocModif.Visible = false;
            this.buttonSocAceptar.Visible = false;
            this.labelSocComisiones.Visible = false;
            this.listBoxSocComisiones.Visible = false;
            this.buttonSocCrear.Visible = true;
            this.buttonSocAceptar.Enabled = false;
        }

        public void prepararFormModificar()
        {
            this.textBoxSocDNI.ReadOnly = true;
            this.buttonSocModif.Visible = true;
            this.buttonSocAceptar.Visible = false;
            this.buttonSocCrear.Visible = false;
            this.labelSocComisiones.Visible = false;
            this.listBoxSocComisiones.Visible = false;
            this.buttonSocModif.Enabled = false;
        }

        public void prepararFormMostrar()
        {
            this.textBoxSocDNI.ReadOnly = true;
            this.textBoxSocNombre.ReadOnly = true;
            this.textBoxSocEmail.ReadOnly = true;
            this.textBoxSocDireccion.ReadOnly = true;
            this.textBoxSocCuotaSocial.ReadOnly = true;
            this.buttonSocAceptar.Visible = true;
            this.listBoxSocComisiones.Enabled = false;
            this.dateTimePickerSocFNac.Enabled = false;
            this.dateTimePickerSocFIng.Enabled = false;
            this.buttonSocCrear.Visible = false;
            this.buttonSocModif.Visible = false;
        }

        public void prepararFormCrearClub()
        {
            this.Text = "Crear Socio Club";
            this.textBoxSocCuotaSocial.Visible = true;
            this.textBoxSocCuotaSocial.Enabled = true;
            prepararFormCrear();
        }

        public void prepararFormModificarClub()
        {
            this.Text = "Modificar Socio Club";
            this.textBoxSocCuotaSocial.Visible = true;
            this.textBoxSocCuotaSocial.Enabled = true;
            prepararFormModificar();
        }

        public void prepararFormMostrarClub()
        {
            this.Text = "Socio Club";
            this.textBoxSocCuotaSocial.Visible = true;
            this.textBoxSocCuotaSocial.Enabled = false;
            prepararFormMostrar();
        }

        public void prepararFormCrearActividad()
        {
            this.Text = "Crear Socio Actividad";
            this.textBoxSocCuotaSocial.Visible = false;
            this.textBoxSocCuotaSocial.Enabled = false;
            this.labelSocCuotaSocial.Visible = false;
            prepararFormCrear();
        }

        public void prepararFormModificarActividad()
        {
            this.Text = "Modificar Socio Actividad";
            this.textBoxSocCuotaSocial.Visible = false;
            this.textBoxSocCuotaSocial.Enabled = false;
            this.labelSocCuotaSocial.Visible = false;
            prepararFormModificar();
        }

        public void prepararFormMostrarActividad()
        {
            this.Text = "Socio Actividad";
            this.textBoxSocCuotaSocial.Visible = false;
            this.textBoxSocCuotaSocial.Enabled = false;
            this.labelSocCuotaSocial.Visible = false;
            prepararFormMostrar();
        }

        private void textBoxSocEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!validEmailAddress(textBoxSocEmail.Text, out errorMsg))
            {
                // Cancelamos el evento.
                e.Cancel = true;
                textBoxSocEmail.Focus();

                // Seteamos el error para mostrar. 
                this.errorProvider.SetError(textBoxSocEmail, errorMsg);
            }
        }

        private void textBoxSocEmail_Validated(object sender, EventArgs e)
        {
            // Si todas las condiciones se cumplen, limpiamos el error.
            errorProvider.SetError(textBoxSocEmail, String.Empty);
        }

        private void textBoxSocDNI_Validating(object sender, CancelEventArgs e)
        {
            string dni = textBoxSocDNI.Text;

            string errorMsg;
            if (!validDni(dni, out errorMsg))
            {
                e.Cancel = true;
                textBoxSocDNI.Focus();

                this.errorProvider.SetError(textBoxSocDNI, errorMsg);
            }
        }

        private void textBoxSocDNI_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxSocDNI, String.Empty);
        }

        private bool validEmailAddress(string emailAddress, out string errorMessage)
        {
            if (emailAddress.Length == 0)
            {
                errorMessage = "La dirección de email es requerida.";
                return false;
            }

            // Chequeamos que haya una '@' y un '.' en el email.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "La dirección de email debe estar en un formato válido.\n" + "Por ejemplo: 'equipo@ejemplo.com' ";
            return false;
        }

        private bool validDni(string dni, out string errorMessage)
        {
            if (dni.Length < 7)
            {
                errorMessage = "El dni debe ser de 7 u 8 dígitos.";
                return false;
            }
            else if (dni.Length > 8)
            {
                errorMessage = "El dni debe ser de 8 dígitos máximo.";
                return false;
            }

            // Chequeamos con una regex que es un entero.
            if (System.Text.RegularExpressions.Regex.IsMatch(dni, "^[0-9]+$"))
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "El dni debe estar en un formato válido.\n" + "Por ejemplo: '11222333' ";
            return false;
        }

        private void textBoxSocNombre_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxSocNombre, String.Empty);
        }

        private void textBoxSocNombre_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!validNombre(textBoxSocNombre.Text, out errorMsg))
            {
                // Cancelamos el evento.
                e.Cancel = true;
                textBoxSocNombre.Focus();

                // Seteamos el error para mostrar. 
                this.errorProvider.SetError(textBoxSocNombre, errorMsg);
            }
        }

        private bool validNombre(string nom, out string errorMessage)
        {
            if (nom.Length > 40)
            {
                errorMessage = "El nombre debe ser de 40 caracteres maximo.";
                return false;
            }
            else if (nom.Length == 0)
            {
                errorMessage = "Debe ingresar un nombre.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void textBoxSocDireccion_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxSocDireccion, String.Empty);
        }

        private void textBoxSocDireccion_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!validDireccion(textBoxSocDireccion.Text, out errorMsg))
            {
                // Cancelamos el evento.
                e.Cancel = true;
                textBoxSocDireccion.Focus();

                // Seteamos el error para mostrar. 
                this.errorProvider.SetError(textBoxSocDireccion, errorMsg);
            }
        }

        private bool validDireccion(string dir, out string errorMessage)
        {
            if (dir.Length > 40)
            {
                errorMessage = "La direccion debe ser de 40 caracteres maximo.";
                return false;
            }
            else if (dir.Length == 0)
            {
                errorMessage = "Debe ingresar una direccion.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void textBoxSocCuotaSocial_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxSocCuotaSocial, String.Empty);
        }

        private void textBoxSocCuotaSocial_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!validCuotaSocial(textBoxSocCuotaSocial.Text, out errorMsg))
            {
                // Cancelamos el evento.
                e.Cancel = true;
                textBoxSocCuotaSocial.Focus();

                // Seteamos el error para mostrar. 
                this.errorProvider.SetError(textBoxSocCuotaSocial, errorMsg);
            }
        }

        private bool validCuotaSocial(string cuo, out string errorMessage)
        {
            if (cuo.Length > 10)
            {
                errorMessage = "Alfonsin v2";
                return false;
            }
            else if (cuo.Length == 0)
            {
                errorMessage = "Debe ingresar un monto.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void textBoxSocDNI_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void textBoxSocNombre_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void textBoxSocEmail_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void textBoxSocDireccion_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void textBoxSocCuotaSocial_TextChanged(object sender, EventArgs e)
        {
            checkInputs();

        }

        private void listBoxSocComisiones_Format(object sender, ListControlConvertEventArgs e)
        {
            string act = ((Comision)e.ListItem).Actividad.Descripcion;
            string id = ((Comision)e.ListItem).Id.ToString();
            string dia = ((Comision)e.ListItem).Dia;
            string horario = ((Comision)e.ListItem).Horario.ToString();

            e.Value = act + " | ID: " + id + " | Día: " + dia + " | Horario: " + horario + "hs";
        }
    }
}
