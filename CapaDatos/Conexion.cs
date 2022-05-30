using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    internal class Conexion
    {
        private string cadenaDeConexion = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=Club; Integrated Security=True";
        SqlConnection conexionSql;

        public SqlConnection establecerConexion()
        {
            conexionSql = new SqlConnection(cadenaDeConexion);
            return conexionSql;
        }

        public int ejectutarComando(string strComando)
        {
            try
            {
                SqlCommand comando = new SqlCommand();

                comando.CommandText = strComando;
                comando.Connection = establecerConexion();
                conexionSql.Open();
                comando.ExecuteNonQuery();
                int a = Convert.ToInt32(comando.ExecuteScalar());
                conexionSql.Close();

                return a;
            }
            catch
            {
                return 0;
            }
        }
        // Sobrecarga INSERT, DELETE, UPDATE
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
            catch (Exception ex)
            {
                return 0;
            }
        }



        // SELECT Retorno de datos
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
