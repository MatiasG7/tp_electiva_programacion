using CapaDatos;
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

        private SocioDatos socDb;
        private InscripcionDatos insDatos;

        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FIng { get => fIng; set => fIng = value; }
        public List<Comision> Comisiones { get => comisiones; }

        public Socio(string email, string direccion, DateTime fIng, int dni, string nombre, DateTime fNac) : base(dni, nombre, fNac)
        {
            this.socDb = new SocioDatos();
            this.insDatos = new InscripcionDatos();
            this.email = email;
            this.direccion = direccion;
            this.fIng = fIng;
            this.comisiones = new List<Comision>();
        }

        public void removerComision(Comision com)
        {
            this.insDatos.removerRelacionPorComYDni(this.Dni, com.Id);
            this.comisiones.Remove(com);
        }

        public void agregarComision(Comision com)
        {
            this.comisiones.Add(com);
        }

        public void agregarInscripcionDb(Comision com)
        {
            this.insDatos.agregarRelacion(this.Dni, com.Id);
        }

        public abstract double calcularMontoAPagar();

        public virtual bool isClub()
        {
            return false;
        }

        public virtual void modificarSocio()
        {
            socDb.modificarActividad(this.Dni, this.Nombre, this.FNac, this.email, this.direccion, this.FIng);
        }

        public void removerRelacionComisionDb(int dni)
        {
            insDatos.removerRelacionPorDni(dni);
        }

        public void removerInscripcionPorComYDni(int id)
        {
            this.insDatos.removerRelacionPorComYDni(this.Dni, id);
        }

        public void removerTodoDb()
        {
            removerRelacionComisionDb(Dni); // Elimino todas las relaciones en la Tabla Inscripcion con el dni de este socio.

            socDb.eliminar(Dni);

            foreach (var com in this.comisiones)
            {
                com.removerSocio(this);
            }
        }
    }
}
