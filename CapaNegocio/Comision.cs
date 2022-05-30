using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    [Serializable]
    public class Comision
    {
        private int id;
        private Actividad actividad;
        private string dia;
        private int horario;
        private List<Socio> socios;
        private Profesor profesor;
        private int cantidadMaximaParticipantes;

        ComisionDatos comDb;
        ProfesorComisionDatos profComDb;

        public int Id { get => id; set => id = value; }
        public Actividad Actividad { get => actividad; set => actividad = value; }
        public string Dia { get => dia; set => dia = value; }
        public int Horario { get => horario; set => horario = value; }
        public Profesor Profesor { get => profesor; set => profesor = value; }
        public int CantidadMaximaParticipantes { get => cantidadMaximaParticipantes; set => cantidadMaximaParticipantes = value; }
        public List<Socio> Socios { get => socios; set => socios = value; }

        public Comision(int id, Actividad actividad, string dia, int horario, Profesor profesor, int cantidadMaximaParticipantes)
        {
            comDb = new ComisionDatos();
            profComDb = new ProfesorComisionDatos();
            this.id = id;
            this.actividad = actividad;
            this.dia = dia;
            this.horario = horario;
            this.profesor = profesor;
            this.cantidadMaximaParticipantes = cantidadMaximaParticipantes;
            this.socios = new List<Socio>();
        }

        public void agregarSocio(Socio newSocio)
        {
            socios.Add(newSocio);
        }

        public void removerSocio(Socio newSocio)
        {
            socios.Remove(newSocio);
        }

        public bool verificarSocio(Socio newSocio)
        {
            return socios.Any(c => c.Dni == newSocio.Dni);
        }

        public bool verificarCantParticipantes()
        {
            return socios.Count() < this.cantidadMaximaParticipantes;
        }

        public void eliminar()
        {
            this.actividad.removerComision(this);
            this.removerDeProfesorYSocios();
            // Remover la relacion entre comision y socio. 
        }

        public void removerComisionesConDniProfesor()
        {
            comDb.eliminarPorDniProfesor(this.profesor.Dni); // Remueve todos las comisiones que contengan el dni de este profesor
        }

        public void removerDeProfesorYSocios()
        {
            this.profesor.removerComision(this);

            foreach (var s in socios)
            {
                s.removerComision(this);
            }
        }

        public override string ToString()
        {
            return this.actividad.Descripcion + " | " + "ID- " + id + " | " + dia + " | " + horario + ":00";
        }

        public void modificarCom(Comision com)
        {
            comDb.modificar(com.Id, com.Actividad.Id, com.Dia, com.Horario, com.Profesor.Dni, com.CantidadMaximaParticipantes);
        }
    }
}
