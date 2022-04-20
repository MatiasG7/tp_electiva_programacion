using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public class SocioActividad : Socio
    {
        public SocioActividad(string email, string direccion, DateTime fIng, int dni, string nombre, DateTime fNac) : base(email, direccion, fIng, dni, nombre, fNac)
        {

        }

        public override double calcularMontoAPagar()
        {
            double montoTotal = 0;

            foreach (var com in Comisiones)
            {
                montoTotal += com.Actividad.Costo;
            }

            return montoTotal;
        }
    }
}
