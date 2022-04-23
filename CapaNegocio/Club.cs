using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    [Serializable]
    public class Club
    {
        List<Actividad> actividades;
        List<Socio> socios;
        List<Profesor> profesores;
        List<Comision> comisiones;
        List<Pago> pagos;

        public List<Actividad> Actividades { get => actividades; set => actividades = value; }
        public List<Profesor> Profesores { get => profesores; set => profesores = value; }
        public List<Socio> Socios { get => socios; set => socios = value; }
        public List<Comision> Comisiones { get => comisiones; set => comisiones = value; }
        public List<Pago> Pagos { get => pagos; set => pagos = value; }

        public Club()
        {
            actividades = new List<Actividad>();
            socios = new List<Socio>();
            profesores = new List<Profesor>();
            comisiones = new List<Comision>();
            pagos = new List<Pago>();
        }

        // verificarActividad devuelve true en caso de que la actividad no se encuentre en el Club.
        public bool verificarActividad(Actividad newAct)
        {
            return actividades.Any(act => act.Id == newAct.Id);
        }

        public bool verificarSocio(Socio newSoc)
        {
            return socios.Any(s => s.Dni == newSoc.Dni);
        }

        public bool verificarProfesor(Profesor newProf)
        {
            return profesores.Any(act => act.Dni == newProf.Dni); ;
        }

        public bool verificarComision(Comision newCom)
        {
            return comisiones.Any(com => com.Id == newCom.Id);
        }

        public void agregarActividad(Actividad newAct)
        {
            actividades.Add(newAct);
        }

        public void agregarSocio(Socio newSoc)
        {
            socios.Add(newSoc);
        }

        public void agregarComision(Comision newCom)
        {
            comisiones.Add(newCom);
        }

        public void agregarProfesor(Profesor newProf)
        {
            profesores.Add(newProf);
        }

        public void agregarPago(Pago newPago)
        {
            this.pagos.Add(newPago);
        }

        public void removerActividad(Actividad act)
        {
            foreach (var c in act.Comisiones)
            {
                comisiones.Remove(c);
            }

            act.limpiarComisiones();
            actividades.Remove(act);
        }

        public void removerSocio(Socio soc)
        {
            socios.Remove(soc);
        }

        public void removerProfesor(Profesor prof)
        {
            profesores.Remove(prof);
        }

        public void removerComision(Comision com)
        {
            comisiones.Remove(com);
        }

        public int calcularIDPago()
        {
            int cant = pagos.Count();
            if (cant == 0)
            {
                return 1;
            }

            return cant + 1;
        }

        // true = ya pagó este mes. false = todavía no pago.
        public bool verificarPago(Socio soc)
        {
            return this.pagos.Any(p => p.Soc == soc && p.Fecha.Month == DateTime.Now.Month && p.Fecha.Year == DateTime.Now.Year);
        }

        public bool guardar()
        {
            return Datos.Guardar(this);
        }

        public static Club Recuperar()
        {
            Club c = (Club)Datos.Recuperar();
            if (c == null)
                c = new Club();
            return c;
        }

    }
}
