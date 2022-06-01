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
        SocioDatos socioDb;
        PagoDatos pagoDb;
        InscripcionDatos insDb;

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
            socioDb = new SocioDatos();
            pagoDb = new PagoDatos();
            insDb = new InscripcionDatos();

            setListsData();
            vincularComisiones();
        }

        private void setListsData()
        {
            // Agrego los objetos de la base de datos a las lists del club.
            actividades = new List<Actividad>(
                    (from dRow in actDb.mostrarActividades().Tables[0].AsEnumerable()
                     select (getActividadData(dRow)))
                );
            profesores = new List<Profesor>(
                    (from dRow in profDb.mostrarProfesores().Tables[0].AsEnumerable()
                     select (getProfesorData(dRow)))
                );
            socios = new List<Socio>(
                    (from dRow in socioDb.get().Tables[0].AsEnumerable()
                     select (getSocioData(dRow)))
                );
            comisiones = new List<Comision>(
                    (from dRow in comDb.mostrarComsiones().Tables[0].AsEnumerable()
                     select (getComisionData(dRow)))
                );
            pagos = new List<Pago>(
                    (from dRow in pagoDb.get().Tables[0].AsEnumerable()
                     select (getPagoData(dRow)))
                );
        }

        private void vincularComisiones()
        {
            List<Tuple<int, int>> inscripciones = new List<Tuple<int, int>>(
                    (from dRow in insDb.get().Tables[0].AsEnumerable()
                     select (getInscripcionData(dRow)))
                );

            // Vinculamos las inscripciones de los socios, tanto en la comision como en el socio.
            foreach (var ins in inscripciones.GroupBy(i => i.Item2))
            {
                Comision com = this.comisiones.Find(c => c.Id == ins.Key);

                foreach (var t in ins.ToList())
                {
                    Socio soc = this.socios.Find(s => s.Dni == t.Item1);
                    com.agregarSocio(soc);
                    soc.agregarComision(com);
                }
            }

            // Vinculamos comisiones con profesor y actividad.
            foreach (var c in this.comisiones)
            {
                c.Profesor.agregarComision(c);      // Vinculamos la comision al profesor.
                c.Actividad.agregarComision(c);     // Vinculamos la comision a la actividad.
            }
        }

        private Actividad getActividadData(DataRow dr) // Obtiene de la table los datos y crea un objecto
        {
            Actividad act = new Actividad((int)dr["ID"], (string)dr["Descripcion"], (double)dr["Costo"]);
            return act;
        }

        private Profesor getProfesorData(DataRow dr)
        {
            Profesor prof = new Profesor((DateTime)dr["FechaIngreso"], (int)dr["DNI"], (string)dr["Nombre"], (DateTime)dr["FechaNacimiento"]);
            return prof;
        }

        private Tuple<int, int> getInscripcionData(DataRow dr)
        {
            return Tuple.Create((int)dr["dniSocio"], (int)dr["idComision"]);
        }

        private Socio getSocioData(DataRow dr)
        {
            Socio soc;
            var cuotaSocial = dr["CuotaSocial"].ToString();

            if (string.IsNullOrEmpty(cuotaSocial))
            {
                soc = new SocioActividad((string)dr["Email"], (string)dr["Direccion"], (DateTime)dr["FechaIngreso"], (int)dr["DNI"], (string)dr["Nombre"], (DateTime)dr["FechaNacimiento"]);
            }
            else
            {
                double cs = Convert.ToDouble(cuotaSocial);
                soc = new SocioClub(cs, (string)dr["Email"], (string)dr["Direccion"], (DateTime)dr["FechaIngreso"], (int)dr["DNI"], (string)dr["Nombre"], (DateTime)dr["FechaNacimiento"]);
            }

            return soc;
        }

        private Comision getComisionData(DataRow dr)
        {
            Comision com = new Comision((int)dr["ID"], actividades.Find(a => a.Id == ((int)dr["idActividad"])), (string)dr["Dia"], (int)dr["Horario"],
                                            profesores.Find(p => p.Dni == ((int)dr["dniProfesor"])), (int)dr["CantMaxParticipantes"]);
            //com.Socios = socios.Where(s => s.Comisiones.Any(c => c.Id == com.Id)).ToList();

            return com;
        }

        private Pago getPagoData(DataRow dr)
        {
            Pago pago = new Pago((int)dr["ID"], (DateTime)dr["Fecha"], socios.Find(s => s.Dni == ((int)dr["dniSocio"])), (double)dr["Monto"]);

            return pago;
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

        public void agregarSocio(Socio newSoc, double cuotaSocial)
        {
            if (cuotaSocial == 0)
            {
                socioDb.agregarActividad(newSoc.Dni, newSoc.Nombre, newSoc.FNac, newSoc.Email, newSoc.Direccion, newSoc.FIng);
            }
            else
            {
                socioDb.agregarClub(newSoc.Dni, newSoc.Nombre, newSoc.FNac, newSoc.Email, newSoc.Direccion, newSoc.FIng, cuotaSocial);
            }

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
            this.pagoDb.agregar(newPago.Fecha, newPago.Soc.Dni, newPago.Monto);
            this.pagos.Add(newPago);
        }

        public void removerActividad(Actividad act)
        {
            foreach (var c in act.Comisiones)
            {
                // Eliminar comisiones de base de datos con este ID
                c.removerRelacionProfesorDb();
                c.removerRelacionSocioDb();
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
            soc.removerTodoDb();

            socios.Remove(soc);
        }

        public void removerProfesor(Profesor prof)
        {
            prof.removerDb();

            profesores.Remove(prof);
        }

        public void removerProfesorCompleto(Profesor prof)
        {
            prof.removerTodoDb();

            profesores.Remove(prof);
        }

        public void removerComision(Comision com)
        {
            com.removerRelacionProfesorDb();
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
