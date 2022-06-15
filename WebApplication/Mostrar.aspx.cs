using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace WebApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string type = ((string)Session["Type"]);
            if (type == null)
            {
                loadEmpty();
            }
            else
            {
                switch (type)
                {
                    case "actividad":
                        loadActividad();
                        break;
                    case "comision":
                        loadComision();
                        break;
                    case "profesor":
                        loadProfesor();
                        break;
                    case "socio":
                        loadSocio();
                        break;
                }
            }
        }

        private void loadActividad()
        {
            Image1.ImageUrl = "~/imagenes/sports.png";
            Page.Title = "Actividad";
            Actividad act = ((Actividad)Session["Actividad"]);
            LabelDescripcion.Text = act.Descripcion;
            LabelID.Text = "Actividad ID: " + act.Id.ToString();
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            if (act.Comisiones.Count() > 0)
            {
                Label6.Text = "Comisiones";
                ListBox1.DataSource = act.Comisiones;
                ListBox1.DataBind();
            }
            else
            {
                Label6.Visible = false;
                ListBox1.Visible = false;
            }
        }

        private void loadComision()
        {
            Image1.ImageUrl = "~/imagenes/sports.png";
            Title = "Comision";
            Comision com = ((Comision)Session["Comision"]);
            LabelDescripcion.Text = "Actividad: " + com.Actividad.Descripcion;
            LabelID.Text = "Comision ID: " + com.Id.ToString();
            Label1.Text = "Dia: " + com.Dia;
            Label2.Text = "Horario: " + com.Horario.ToString();
            Label3.Text = "Cantidad maxima de participantes " + com.CantidadMaximaParticipantes.ToString();
            Label4.Visible = false;
            Label5.Visible = false;
            if (com.Socios.Count() > 0)
            {
                Label6.Text = "Socios";
                ListBox1.DataSource = com.Socios;
                ListBox1.DataBind();
            }
            else
            {
                Label6.Visible = false;
                ListBox1.Visible = false;
            }
        }

        private void loadProfesor()
        {
            Image1.ImageUrl = "~/imagenes/profesor.png";
            Title = "Profesor";
            Profesor prof = ((Profesor)Session["Profesor"]);
            LabelID.Text = "Profesor DNI: " + prof.Dni.ToString();
            LabelDescripcion.Text = prof.Nombre;
            Label1.Text = "Fecha de nacimiento: " + prof.FIng.ToString("dd/MM/yyyy");
            Label2.Text = "Fecha de ingreso: " + prof.FNac.ToString("dd/MM/yyyy");
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            ListBox1.Visible = false;
        }

        private void loadSocio()
        {
            Image1.ImageUrl = "~/imagenes/socio.png";
            Title = "Socio";

            Socio soc = ((Socio)Session["Socio"]);

            LabelID.Text = "Socio DNI: " + soc.Dni.ToString();
            LabelDescripcion.Text = soc.Nombre;
            Label1.Text = "Fecha de nacimiento: " + soc.FNac.ToString("dd/MM/yyyy");
            Label2.Text = "Email: " + soc.Email;
            Label3.Text = "Direccion: " + soc.Direccion;
            Label4.Text = "Fecha de ingreso: " + soc.FIng.ToString("dd/MM/yyyy");

            if (soc.GetType().Name == "SocioClub")
            {
                SocioClub socClub = (SocioClub)soc;
                Label5.Text = "Cuota social: " + socClub.CuotaSocial;
            }
            else
            {
                Label5.Visible = false;
            }

            if (soc.Comisiones.Count() > 0)
            {
                Label6.Text = "Comisiones";
                ListBox1.DataSource = soc.Comisiones;
                ListBox1.DataBind();
            }
            else
            {
                Label6.Visible = false;
                ListBox1.Visible = false;
            }

        }

        private void loadEmpty()
        {
            LabelID.Text = "No hubo seleccion.";
            LabelDescripcion.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            Label6.Visible = false;
            ListBox1.Visible = false;
            Image1.Visible = false;
        }
    }
}