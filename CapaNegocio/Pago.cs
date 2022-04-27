using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public class Pago
    {
        private int id;
        private DateTime fecha;
        private Socio soc;
        private double monto;

        public Pago(int id, Socio soc, double monto)
        {
            this.id = id;
            this.fecha = DateTime.Now;
            this.soc = soc;
            this.monto = monto;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Socio Soc { get => soc; set => soc = value; }
        public double Monto { get => monto; set => monto = value; }

        public override string ToString()
        {
            return fecha + " - $" + monto + " - " + soc.Nombre;
        }
    }
}
