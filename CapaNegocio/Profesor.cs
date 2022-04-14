using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public class Profesor : Persona
    {
        private DateTime fIng;

        public DateTime FIng { get => fIng; set => fIng = value; }

        public Profesor(DateTime fIng, int dni, string nombre, DateTime fNac) : base(dni, nombre, fNac)
        {
            this.fIng = fIng;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + fIng.ToString();
        }
    }
}
