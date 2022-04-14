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
    }
}
