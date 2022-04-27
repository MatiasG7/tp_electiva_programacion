using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public abstract class Socio : Persona
    {
        private string email;
        private string direccion;
        private DateTime fIng;
        private List<Comision> comisiones;

        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FIng { get => fIng; set => fIng = value; }
        public List<Comision> Comisiones { get => comisiones; }

        public Socio(string email, string direccion, DateTime fIng, int dni, string nombre, DateTime fNac) : base(dni, nombre, fNac)
        {
            this.email = email;
            this.direccion = direccion;
            this.fIng = fIng;
            this.comisiones = new List<Comision>();
        }

        public void removerComision(Comision com)
        {
            this.comisiones.Remove(com);
        }

        public void agregarComision(Comision com)
        {
            this.comisiones.Add(com);
        }

        public abstract double calcularMontoAPagar();

        public virtual bool isClub()
        {
            return false;
        }
    }
}
