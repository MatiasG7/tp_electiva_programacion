using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;


namespace WebApplication
{
    public partial class _Default : Page
    {
        Club club = new Club();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListBoxActividades.DataSource = club.Actividades;
                ListBoxActividades.DataBind();

            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actividad act = club.Actividades[ListBoxActividades.SelectedIndex];
            ListBoxComisiones.DataSource = act.Comisiones;
            ListBoxComisiones.DataBind();
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}