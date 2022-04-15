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
        private List<Comision> comisiones;

        public DateTime FIng { get => fIng; set => fIng = value; }

        public Profesor(DateTime fIng, int dni, string nombre, DateTime fNac) : base(dni, nombre, fNac)
        {
            this.fIng = fIng;
            this.comisiones = new List<Comision>();
        }

        public override string ToString()
        {
            return base.ToString() + " - " + fIng.Date.ToString("dd/MM/yyyy");
        }
    }
}
