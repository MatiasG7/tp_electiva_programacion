using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Actividad
    {
        private int id;
        private string descripcion;
        private double costo;
        private List<Comision> comisiones;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Costo { get => costo; set => costo = value; }
        public List<Comision> Comisiones { get => comisiones; }

        public Actividad(int id, string descripcion, double costo)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.costo = costo;
            this.comisiones = new List<Comision>();
        }
    }
}
