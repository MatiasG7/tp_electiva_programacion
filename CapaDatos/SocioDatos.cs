using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class SocioDatos
    {
        Conexion conexion;

        public SocioDatos()
        {
            conexion = new Conexion();
        }

        public int agregarClub(int dni, string nombre, DateTime fNac, string email, string direccion, DateTime fIng, double cuotaSocial)
        {
            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[Socio]([DNI],[Nombre],[FechaNacimiento],[Email],[Direccion],[FechaIngreso],[CuotaSocial]) " +
                                                    "VALUES(@Dni,@Nombre,@FechaDeNacimiento,@Email,@Direccion,@FechaDeIngreso,@CuotaSocial); SELECT SCOPE_IDENTITY()");

            SqlComando.Parameters.Add("@Dni", SqlDbType.Int).Value = dni;
            SqlComando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            SqlComando.Parameters.Add("@FechaDeNacimiento", SqlDbType.DateTime).Value = fNac;
            SqlComando.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            SqlComando.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = direccion;
            SqlComando.Parameters.Add("@FechaDeIngreso", SqlDbType.DateTime).Value = fIng;
            SqlComando.Parameters.Add("@CuotaSocial", SqlDbType.Float).Value = cuotaSocial;

            int modified = conexion.ejectutarComando(SqlComando);

            return modified;
        }

        public int agregarActividad(int dni, string nombre, DateTime fNac, string email, string direccion, DateTime fIng)
        {
            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[Socio]([DNI],[Nombre],[FechaNacimiento],[Email],[Direccion],[FechaIngreso]) " +
                                                    "VALUES(@Dni,@Nombre,@FechaDeNacimiento,@Email,@Direccion,@FechaDeIngreso); SELECT SCOPE_IDENTITY()");

            SqlComando.Parameters.Add("@Dni", SqlDbType.Int).Value = dni;
            SqlComando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            SqlComando.Parameters.Add("@FechaDeNacimiento", SqlDbType.DateTime).Value = fNac;
            SqlComando.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            SqlComando.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = direccion;
            SqlComando.Parameters.Add("@FechaDeIngreso", SqlDbType.DateTime).Value = fIng;

            int modified = conexion.ejectutarComando(SqlComando);

            return modified;
        }

        public int eliminar(int dni)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[Socio] WHERE DNI=(@Dni)");

            SqlComando.Parameters.Add("@Dni", SqlDbType.VarChar).Value = dni;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        public int modificarClub(int dni, string nombre, DateTime fechaDeNacimiento, string email, string direccion, DateTime fechaDeIngreso, double cuotaSocial)
        {
            SqlCommand SqlComando = new SqlCommand("UPDATE [dbo].[Socio]" +
                "                                   SET Nombre = (@Nombre), FechaNacimiento = (@FechaDeNacimiento), Email = (@Email), Direccion = (@Direccion), FechaIngreso = (@FechaDeIngreso), CuotaSocial = (@CuotaSocial) " +
                "                                   WHERE DNI=(@Dni)");

            SqlComando.Parameters.Add("@Dni", SqlDbType.Int).Value = dni;
            SqlComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
            SqlComando.Parameters.Add("@FechaDeNacimiento", SqlDbType.DateTime).Value = fechaDeNacimiento;
            SqlComando.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            SqlComando.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = direccion;
            SqlComando.Parameters.Add("@FechaDeIngreso", SqlDbType.DateTime).Value = fechaDeIngreso;
            SqlComando.Parameters.Add("@CuotaSocial", SqlDbType.Float).Value = cuotaSocial;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        public int modificarActividad(int dni, string nombre, DateTime fechaDeNacimiento, string email, string direccion, DateTime fechaDeIngreso)
        {
            SqlCommand SqlComando = new SqlCommand("UPDATE [dbo].[Socio]" +
                "                                   SET Nombre = (@Nombre), FechaNacimiento = (@FechaDeNacimiento), Email = (@Email), Direccion = (@Direccion), FechaIngreso = (@FechaDeIngreso) " +
                "                                   WHERE DNI=(@Dni)");

            SqlComando.Parameters.Add("@Dni", SqlDbType.Int).Value = dni;
            SqlComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
            SqlComando.Parameters.Add("@FechaDeNacimiento", SqlDbType.DateTime).Value = fechaDeNacimiento;
            SqlComando.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            SqlComando.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = direccion;
            SqlComando.Parameters.Add("@FechaDeIngreso", SqlDbType.DateTime).Value = fechaDeIngreso;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        public DataSet get()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM [dbo].[Socio]");

            return conexion.ejecutarSentencia(sentencia);
        }
    }
}
