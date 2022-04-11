using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public abstract class Persona
    {
        private int dni;
        private string nombre;
        private DateTime fNac;

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FNac { get => fNac; set => fNac = value; }

        public Persona(int dni, string nombre, DateTime fNac)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.fNac = fNac;
        }
    }
}
