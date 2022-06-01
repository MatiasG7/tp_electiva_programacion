using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    internal class Conexion
    {
        SqlConnection conexionSql;

        public static string GetConnectionString(string connectionName = "localhost")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public SqlConnection establecerConexion()
        {
            conexionSql = new SqlConnection(GetConnectionString());
            return conexionSql;
        }

        // INSERT, DELETE, UPDATE
        public int ejectutarComando(SqlCommand SqlComando)
        {
            try
            {
                SqlCommand comando = SqlComando;
                comando.Connection = establecerConexion();
                conexionSql.Open();
                int a = Convert.ToInt32(comando.ExecuteScalar());
                conexionSql.Close();

                return a;
            }
            catch
            {
                return 0;
            }
        }

        // SELECT
        public DataSet ejecutarSentencia(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand comando = new SqlCommand();
                comando = sqlComando;

                comando.Connection = establecerConexion();
                adaptador.SelectCommand = comando;

                conexionSql.Open();
                adaptador.Fill(DS);
                conexionSql.Close();

                return DS;
            }
            catch
            {
                return DS;
            }
        }

    }



}
