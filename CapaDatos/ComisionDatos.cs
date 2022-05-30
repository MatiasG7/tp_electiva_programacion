using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{

    public class ComisionDatos
    {
        Conexion conexion;

        public ComisionDatos()
        {
            conexion = new Conexion();
        }

        public int agregar(int idAct, string dia, int horario, int dniProfesor, int cantMaxPart)
        {

            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[Comision]([idActividad],[Dia],[Horario],[dniProfesor],[CantMaxParticipantes]) " +
                                                    "VALUES(@IdAct,@Dia,@Horario,@DniProfersor,@CantMaxPart); SELECT SCOPE_IDENTITY()");

            SqlComando.Parameters.Add("@IdAct", SqlDbType.Int).Value = idAct;
            SqlComando.Parameters.Add("@Dia", SqlDbType.VarChar).Value = dia;
            SqlComando.Parameters.Add("@Horario", SqlDbType.VarChar).Value = horario;
            SqlComando.Parameters.Add("@DniProfersor", SqlDbType.Int).Value = dniProfesor;
            SqlComando.Parameters.Add("@CantMaxPart", SqlDbType.Int).Value = cantMaxPart;

            int modified = conexion.ejectutarComando(SqlComando);

            return modified;

            //return conexion.ejectutarComando("INSERT INTO[dbo].[Actividad]([Descripcion],[Costo]) " +
            //    "VALUES('" + desc + "', " + (float)cost + ")");
        }

        public DataSet mostrarComsiones()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM[dbo].[Comision]");

            return conexion.ejecutarSentencia(sentencia);
        }

        public int eliminar(int id)
        {

            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[Comision] WHERE ID=(@Id)");

            SqlComando.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;

            // conexion.ejectutarComando("DELETE FROM [dbo].[Actividad] WHERE ID=" + id + " ");

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        public int modificar(int id, int idAct, string dia, int horario, int dniProfesor, int cantMaxPart)
        {
            SqlCommand SqlComando = new SqlCommand("UPDATE [dbo].[Comision]" +
                "                                   SET Dia = (@Dia), Horario = (@Horario), dniProfesor = (@DniProfersor), CantMaxParticipantes = (@CantMaxPart) " +
                "                                   WHERE ID=(@Id)");

            SqlComando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            SqlComando.Parameters.Add("@Dia", SqlDbType.VarChar).Value = dia;
            SqlComando.Parameters.Add("@Horario", SqlDbType.VarChar).Value = horario;
            SqlComando.Parameters.Add("@DniProfersor", SqlDbType.Int).Value = dniProfesor;
            SqlComando.Parameters.Add("@CantMaxPart", SqlDbType.Int).Value = cantMaxPart;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        public int eliminarPorDniProfesor(int dni)
        {

            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[Comision] WHERE dniProfesor=(@Dni)");

            SqlComando.Parameters.Add("@Dni", SqlDbType.VarChar).Value = dni;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }
    }
}
