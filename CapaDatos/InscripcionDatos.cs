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
            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[Inscripcion]([idComision],[dniSocio]) VALUES (@IdComision,@Dni)");

            SqlComando.Parameters.Add("@Dni", SqlDbType.Int).Value = Dni;
            SqlComando.Parameters.Add("@IdComision", SqlDbType.Int).Value = idComision;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        // REMOVER con unicamente Dni
        public int removerRelacionPorDni(int dni)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[Inscripcion] WHERE dniSocio=(@dniSocio)");

            SqlComando.Parameters.Add("@dniSocio", SqlDbType.Int).Value = dni;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        // REMOVER con unicamente idCom
        public int removerRelacionPorIdCom(int idCom)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[Inscripcion] WHERE idComision=(@IdCom)");

            SqlComando.Parameters.Add("@IdCom", SqlDbType.Int).Value = idCom;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        public int removerRelacionPorComYDni(int dni, int idCom)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[Inscripcion] WHERE idComision=(@IdCom) AND dniSocio=(@dniSocio)");

            SqlComando.Parameters.Add("@IdCom", SqlDbType.Int).Value = idCom;
            SqlComando.Parameters.Add("@dniSocio", SqlDbType.Int).Value = dni;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        public DataSet get()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM [dbo].[Inscripcion]");

            return conexion.ejecutarSentencia(sentencia);
        }
    }
}
