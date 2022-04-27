using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
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

        public void removerComision(Comision c)
        {
            comisiones.Remove(c);
        }

        public void eliminar()
        {
            foreach (var c in comisiones)
            {
                c.removerDeProfesorYSocios();
            }
        }

        public void limpiarComisiones()
        {
            this.comisiones.Clear();
        }
    }
}
