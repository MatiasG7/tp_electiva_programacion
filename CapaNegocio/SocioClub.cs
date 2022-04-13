using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
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
    }
}
