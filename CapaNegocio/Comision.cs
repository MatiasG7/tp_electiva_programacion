using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Id { get => id; set => id = value; }
        public Actividad Actividad { get => actividad; set => actividad = value; }
        public string Dia { get => dia; set => dia = value; }
        public int Horario { get => horario; set => horario = value; }
        public Profesor Profesor { get => profesor; set => profesor = value; }
        public int CantidadMaximaParticipantes { get => cantidadMaximaParticipantes; set => cantidadMaximaParticipantes = value; }
        public List<Socio> Socios { get => socios; }

        public Comision(int id, Actividad actividad, string dia, int horario, Profesor profesor, int cantidadMaximaParticipantes)
        {
            this.id = id;
            this.actividad = actividad;
            this.dia = dia;
            this.horario = horario;
            this.profesor = profesor;
            this.cantidadMaximaParticipantes = cantidadMaximaParticipantes;
            this.socios = new List<Socio>();
        }

        public override string ToString()
        {
            return dia + " - " + horario;
        }
    }
}
