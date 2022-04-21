using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public class SocioClub : Socio
    {
        private static int CantMaxActividades;
        private static int PorcentajeDescuento;
        private double cuotaSocial;

        public double CuotaSocial { get => cuotaSocial; set => cuotaSocial = value; }

        public SocioClub(double cuotaSocial, string email, string direccion, DateTime fIng, int dni, string nombre, DateTime fNac) : base(email, direccion, fIng, dni, nombre, fNac)
        {
            this.cuotaSocial = cuotaSocial;
        }

        public override double calcularMontoAPagar()
        {
            double montoTotal = this.cuotaSocial;

            List<Comision> coms = this.Comisiones.OrderBy(c => c.Actividad.Costo).ToList();

            if (coms.Count() > GetMaxCantActividades())
            {

                coms = coms.GetRange(GetMaxCantActividades(), coms.Count() - GetMaxCantActividades());

                foreach (var com in coms)
                {
                    montoTotal += (com.Actividad.Costo * (1 - (Convert.ToDouble(SocioClub.GetPorcentajeDescuento()) / 100)));
                }
            }

            return montoTotal;
        }

        private static int GetMaxCantActividades()
        {
            return CantMaxActividades;
        }

        public static void SetMaxCantActividades(int cant)
        {
            CantMaxActividades = cant;
        }

        private static int GetPorcentajeDescuento()
        {
            return PorcentajeDescuento;
        }

        public static void SetPorcentajeDescuento(int desc)
        {
            PorcentajeDescuento = desc;
        }
    }
}
