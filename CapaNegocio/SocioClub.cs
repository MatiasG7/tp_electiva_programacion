using CapaDatos;
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
        private SocioDatos socDb;

        public double CuotaSocial { get => cuotaSocial; set => cuotaSocial = value; }

        public SocioClub(double cuotaSocial, string email, string direccion, DateTime fIng, int dni, string nombre, DateTime fNac) : base(email, direccion, fIng, dni, nombre, fNac)
        {
            socDb = new SocioDatos();
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
                    montoTotal += (com.Actividad.Costo * (Convert.ToDouble(SocioClub.GetPorcentajeDescuento()) / 100));
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

        public override string ToString()
        {
            return base.ToString() + " - Club";
        }

        public override bool isClub()
        {
            return true;
        }

        public override void modificarSocio()
        {
            socDb.modificarClub(this.Dni, this.Nombre, this.FNac, this.Email, this.Direccion, this.FIng, this.cuotaSocial);
        }
    }
}
