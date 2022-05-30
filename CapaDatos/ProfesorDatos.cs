using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ProfesorDatos
    {
        Conexion conexion;

        public ProfesorDatos()
        {
            conexion = new Conexion();
        }

        public int agregar(int dni, string nombre, DateTime fechaDeNacimiento, DateTime fechaDeIngreso)
        {

            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[Profesor]([DNI],[Nombre],[FechaNacimiento],[FechaIngreso]) " +
                                                    "VALUES(@Dni,@Nombre,@FechaDeNacimiento,@FechaDeIngreso); SELECT SCOPE_IDENTITY()");

            SqlComando.Parameters.Add("@Dni", SqlDbType.Int).Value = dni;
            SqlComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
            SqlComando.Parameters.Add("@FechaDeNacimiento", SqlDbType.DateTime).Value = fechaDeNacimiento;
            SqlComando.Parameters.Add("@FechaDeIngreso", SqlDbType.DateTime).Value = fechaDeIngreso;

            int modified = conexion.ejectutarComando(SqlComando);

            return modified;
        }

        public DataSet mostrarProfesores()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM[dbo].[Profesor]");

            return conexion.ejecutarSentencia(sentencia);
        }

        public int eliminar(int dni)
        {

            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[Profesor] WHERE DNI=(@Dni)");

            SqlComando.Parameters.Add("@Dni", SqlDbType.VarChar).Value = dni;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        public int modificar(int dni, string nombre, DateTime fechaDeNacimiento, DateTime fechaDeIngreso)
        {
            SqlCommand SqlComando = new SqlCommand("UPDATE [dbo].[Profesor]" +
                "                                   SET Nombre = (@Nombre), FechaNacimiento = (@FechaDeNacimiento), FechaIngreso = (@FechaDeIngreso) " +
                "                                   WHERE DNI=(@Dni)");

            SqlComando.Parameters.Add("@Dni", SqlDbType.Int).Value = dni;
            SqlComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
            SqlComando.Parameters.Add("@FechaDeNacimiento", SqlDbType.DateTime).Value = fechaDeNacimiento;
            SqlComando.Parameters.Add("@FechaDeIngreso", SqlDbType.DateTime).Value = fechaDeIngreso;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }
    }
}
