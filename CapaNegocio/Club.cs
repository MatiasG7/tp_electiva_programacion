using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        ActividadDatos actDb;
        ComisionDatos comDb;
        ProfesorDatos profDb;

        public List<Actividad> Actividades { get => actividades; set => actividades = value; }
        public List<Profesor> Profesores { get => profesores; set => profesores = value; }
        public List<Socio> Socios { get => socios; set => socios = value; }
        public List<Comision> Comisiones { get => comisiones; set => comisiones = value; }
        public List<Pago> Pagos { get => pagos; set => pagos = value; }

        public Club()
        {
            actDb = new ActividadDatos();
            comDb = new ComisionDatos();
            profDb = new ProfesorDatos();

            // Agrego los objectos de la base de datos a las lists de club
            actividades = new List<Actividad>(
                    (from dRow in actDb.mostrarActividades().Tables[0].AsEnumerable()
                     select (getActividadData(dRow)))
                );
            profesores = new List<Profesor>(
                    (from dRow in profDb.mostrarProfesores().Tables[0].AsEnumerable()
                     select (getProfesorData(dRow)))
                );

            comisiones = new List<Comision>(
                    (from dRow in comDb.mostrarComsiones().Tables[0].AsEnumerable()
                     select (getComisionData(dRow)))
                );

            vincularComisionesProfesor();

            socios = new List<Socio>();
            pagos = new List<Pago>();

        }

        private Actividad getActividadData(DataRow dr) // Obtiene de la table los datos y crea un objecto
        {
            Actividad oAct = new Actividad((int)dr["ID"], (string)dr["Descripcion"], (double)dr["Costo"]);
            return oAct;
        }

        private Comision getComisionData(DataRow dr)
        {
            Comision oCom = new Comision((int)dr["ID"], actividades.Find(x => x.Id == ((int)dr["idActividad"])), (string)dr["Dia"], (int)dr["Horario"],
                                            profesores.Find(x => x.Dni == ((int)dr["dniProfesor"])), (int)dr["CantMaxParticipantes"]);
            return oCom;
        }

        private Profesor getProfesorData(DataRow dr)
        {
            Profesor oProf = new Profesor((DateTime)dr["FechaIngreso"], (int)dr["DNI"], (string)dr["Nombre"], (DateTime)dr["FechaNacimiento"]);
            return oProf;
        }

        private void vincularComisionesProfesor()
        {
            foreach (var c in this.comisiones)
            {
                c.Profesor.agregarComision(c);
            }
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
            int idReturned = actDb.agregar(newAct.Descripcion, newAct.Costo);
            newAct.Id = idReturned;
            actividades.Add(newAct);
        }

        public void agregarSocio(Socio newSoc)
        {
            socios.Add(newSoc);
        }

        public void agregarComision(Comision newCom)
        {
            int idReturned = comDb.agregar(newCom.Actividad.Id, newCom.Dia, newCom.Horario, newCom.Profesor.Dni, newCom.CantidadMaximaParticipantes);
            newCom.Id = idReturned;


            comisiones.Add(newCom);
        }

        public void agregarProfesor(Profesor newProf)
        {
            profDb.agregar(newProf.Dni, newProf.Nombre, newProf.FNac, newProf.FIng);
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
                // Eliminar comisiones de base de datos con este ID
                comDb.eliminar(c.Id);
                comisiones.Remove(c);
            }

            act.limpiarComisiones();
            actividades.Remove(act);

            // Borrar en base de datos
            actDb.eliminar(act.Id);
        }

        public void removerSocio(Socio soc)
        {
            socios.Remove(soc);
        }

        public void removerProfesor(Profesor prof)
        {
            prof.removerTodoDb();

            profesores.Remove(prof);
        }

        public void removerComision(Comision com)
        {
            comDb.eliminar(com.Id);
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
