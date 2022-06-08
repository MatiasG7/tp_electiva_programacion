using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    [Serializable]
    public class Actividad
    {
        private int id;
        private string descripcion;
        private double costo;
        private List<Comision> comisiones;

        ActividadDatos actDb;
        ActividadComisionDatos actComDb;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Costo { get => costo; set => costo = value; }
        public List<Comision> Comisiones { get => comisiones; }

        public Actividad(int id, string descripcion, double costo)
        {
            actDb = new ActividadDatos();
            actComDb = new ActividadComisionDatos();
            this.id = id;
            this.descripcion = descripcion;
            this.costo = costo;
            this.comisiones = new List<Comision>();
        }

        public override string ToString()
        {
            return "ID-" + id + " | " + descripcion + " | $" + costo;
        }

        public bool verificarComision(Comision newCom)
        {
            return comisiones.Any(c => c.Id == newCom.Id);
        }

        public void agregarComision(Comision newCom)
        {
            comisiones.Add(newCom);
        }

        public void agregarComisionDb(Comision newCom)
        {
            actComDb.agregarRelacion(this.id, newCom.Id);
        }

        public void removerComision(Comision c)
        {
            comisiones.Remove(c);
            // DB: Remueve todas las relaciones en la base de datos que contengan este Id Comision
            actComDb.removerRelacionIdCom(c.Id);
        }

        public void eliminarRelacionComision()
        {
            actComDb.removerRelacionIdAct(id); // Remover de la base de datos TODAS las relaciones que contengan el ID de esta actividad
        }

        public void limpiarComisiones()
        {
            this.comisiones.Clear();
        }

        public void modificarAct(Actividad act)
        {
            actDb.modificar(act.Id, act.Descripcion, act.Costo); // Enviamos a actDb.modificar los datos a modificar
        }
    }
}
