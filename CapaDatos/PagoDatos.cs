using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class PagoDatos
    {
        Conexion conexion;

        public PagoDatos()
        {
            conexion = new Conexion();
        }

        public int agregar(DateTime fecha, int dniSocio, double monto)
        {
            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[Pago]([Fecha],[dniSocio],[Monto]) " +
                                                    "VALUES(@Fecha,@dniSocio,@Monto); SELECT SCOPE_IDENTITY()");

            SqlComando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = fecha;
            SqlComando.Parameters.Add("@dniSocio", SqlDbType.Int).Value = dniSocio;
            SqlComando.Parameters.Add("@Monto", SqlDbType.Float).Value = monto;

            int modified = conexion.ejectutarComando(SqlComando);

            return modified;
        }

        public DataSet get()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM [dbo].[Pago]");

            return conexion.ejecutarSentencia(sentencia);
        }
    }
}
