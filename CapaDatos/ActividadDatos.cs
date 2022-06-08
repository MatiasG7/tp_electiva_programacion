using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ActividadDatos
    {
        Conexion conexion;

        public ActividadDatos()
        {
            conexion = new Conexion();
        }

        public int agregar(string desc, double cost)
        {

            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[Actividad]([Descripcion],[Costo]) VALUES(@Descripcion,@Costo); SELECT SCOPE_IDENTITY()");

            SqlComando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = desc;
            SqlComando.Parameters.Add("@Costo", SqlDbType.Float).Value = (float)cost;

            // Envia el parametro y este al completarlo devuelve el ID del elemento creado en la base de datos
            int modified = conexion.ejectutarComando(SqlComando);

            return modified;
        }

        public DataSet mostrarActividades()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM[dbo].[Actividad]");

            return conexion.ejecutarSentencia(sentencia);
        }

        public int eliminar(int id)
        {

            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[Actividad] WHERE ID=(@Id)");

            SqlComando.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        public int modificar(int id, string desc, double costo)
        {
            SqlCommand SqlComando = new SqlCommand("UPDATE [dbo].[Actividad] SET Descripcion=(@Descripcion), Costo=(@Costo) WHERE ID=(@Id)");

            SqlComando.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
            SqlComando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = desc;
            SqlComando.Parameters.Add("@Costo", SqlDbType.Float).Value = (float)costo;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }
    }
}
