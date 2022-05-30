using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    [Serializable]
    public class Profesor : Persona
    {
        private DateTime fIng;
        private List<Comision> comisiones;

        ProfesorDatos profDb;
        ProfesorComisionDatos profComDb;
        ComisionDatos comDb;
        ActividadComisionDatos actComDatos;
        InscripcionDatos insDatos;

        public DateTime FIng { get => fIng; set => fIng = value; }
        public List<Comision> Comisiones { get => comisiones; set => comisiones = value; }

        public Profesor(DateTime fIng, int dni, string nombre, DateTime fNac) : base(dni, nombre, fNac)
        {
            profDb = new ProfesorDatos();
            profComDb = new ProfesorComisionDatos();
            comDb = new ComisionDatos();
            actComDatos = new ActividadComisionDatos();
            insDatos = new InscripcionDatos();

            this.fIng = fIng;
            this.comisiones = new List<Comision>();
        }

        public void agregarComision(Comision newCom)
        {
            comisiones.Add(newCom);
        }
        public void removerComision(Comision newCom)
        {
            comisiones.Remove(newCom);
        }

        public override string ToString()
        {
            return base.ToString() + " - " + fIng.Date.ToString("dd/MM/yyyy");
        }

        public void limpiarComisiones()
        {
            foreach (var com in comisiones.ToArray())
            {
                com.eliminar();
            }

            this.comisiones.Clear();
        }

        public void modificarProfesor(Profesor prof)
        {
            profDb.modificar(base.Dni, base.Nombre, base.FNac, fIng);
        }

        public void agregarComisionDb(Comision com)
        {
            profComDb.agregarRelacion(this.Dni, com.Id);
        }

        public void removerRelacionComisionDb(int dni)
        {
            profComDb.removerRelacionDni(dni);
        }

        public void removerTodoDb()
        {
            removerRelacionComisionDb(Dni); // Elimino todas las relaciones en la Tabla ProfesorComision con el dni de este profesor

            foreach (var com in comisiones) // Recorro todas las comisiones dentro de este profesor
            {
                actComDatos.removerRelacionIdCom(com.Id); // Elimino todas las relaciones en ActividadComision con el id Comision
                insDatos.removerRelacionPorIdCom(com.Id); // Elimino todas las relaciones en Inscripcion con el id Comision
            }
            comDb.eliminarPorDniProfesor(Dni); // Elimino todas las comisiones que tienen el dni de este profesor

            profDb.eliminar(Dni); // Elimina profesor de la base de datos Tabla Profesor
        }
    }
}
