using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ProfesorComisionDatos
    {
        Conexion conexion;

        public ProfesorComisionDatos()
        {
            conexion = new Conexion();
        }

        public int agregarRelacion(int dni, int idCom)
        {
            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[ProfesorComision]([dniProfesor],[idComision]) " +
                                                    "VALUES(@Dni,@IdCom)");

            SqlComando.Parameters.Add("@Dni", SqlDbType.Int).Value = dni;
            SqlComando.Parameters.Add("@IdCom", SqlDbType.Int).Value = idCom;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        // REMOVER con ambos idCom y idCom
        public int removerRelacion(int dni, int idCom)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[ProfesorComision] WHERE (dniProfesor=(@Dni) AND idComision=(@IdCom)");

            SqlComando.Parameters.Add("@Dni", SqlDbType.Int).Value = dni;
            SqlComando.Parameters.Add("@IdCom", SqlDbType.Int).Value = idCom;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        // REMOVER con unicamente idCom
        public int removerRelacionIdCom(int idCom)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[ProfesorComision] WHERE idComision=(@IdCom)");

            SqlComando.Parameters.Add("@IdCom", SqlDbType.Int).Value = idCom;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        // REMOVER con unicamente Dni
        public int removerRelacionDni(int dni)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[ProfesorComision] WHERE dniProfesor=(@Dni)");

            SqlComando.Parameters.Add("@Dni", SqlDbType.Int).Value = dni;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }
    }
}
