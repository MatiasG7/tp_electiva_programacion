using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class InscripcionDatos
    {
        Conexion conexion;

        public InscripcionDatos()
        {
            conexion = new Conexion();
        }

        public int agregarRelacion(int Dni, int idComision)
        {
            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[Inscripcion]([idComision],[dniSocio]) " +
                                                    "VALUES(@IdComision,@Dni)");

            SqlComando.Parameters.Add("@Dni", SqlDbType.Int).Value = Dni;
            SqlComando.Parameters.Add("@IdComision", SqlDbType.Int).Value = idComision;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        // REMOVER con unicamente Dni

        // REMOVER con unicamente idCom
        public int removerRelacionPorIdCom(int idCom)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[Inscripcion] WHERE idComision=(@IdCom)");

            SqlComando.Parameters.Add("@IdCom", SqlDbType.Int).Value = idCom;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }
    }
}
