using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Club
    {
        List<Actividad> actividades;
        List<Socio> socios;
        List<Profesor> profesores;

        public List<Actividad> Actividades { get => actividades; set => actividades = value; }

        public void agregarSocio(Socio s)
        {
            socios.Add(s);
        }

        // verificarActividad devuelve true en caso de que la actividad no se encuentre en el Club.
        public bool verificarActividad(Actividad newAct)
        {
            bool exists = actividades.Any(act => act.Id == newAct.Id);
            if (!exists)
            {
                actividades.Add(newAct);
                return false;
            }

            return exists;
        }

        public void removerActividad(Actividad act)
        {
            actividades.Remove(act);
        }
    }
}
