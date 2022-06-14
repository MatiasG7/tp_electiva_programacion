using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace WebApplication
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string type = ((string)Session["Type"]);
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

        private void loadActividad()
        {
            Actividad act = ((Actividad)Session["Actividad"]);
            LabelActividad.Visible = false;
            LabelActividad.Text = act.Descripcion;
            LabelID.Text = act.Id.ToString();
        }

        private void loadComision()
        {
            Comision com = ((Comision)Session["Comision"]);
            LabelActividad.Text = com.Id.ToString();
        }

        private void loadProfesor()
        {
            Profesor prof = ((Profesor)Session["Profesor"]);
            LabelActividad.Text = prof.Nombre;
        }

        private void loadSocio()
        {
            Socio soc = ((Socio)Session["Socio"]);
            LabelActividad.Text = soc.Nombre;
        }
    }
}