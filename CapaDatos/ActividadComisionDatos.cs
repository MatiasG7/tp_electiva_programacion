using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ActividadComisionDatos
    {
        Conexion conexion;

        public ActividadComisionDatos()
        {
            conexion = new Conexion();
        }

        public int agregarRelacion(int idAct, int idCom)
        {
            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[ActividadComision]([idActividad],[idComision]) " +
                                                    "VALUES(@IdAct,@IdCom)");

            SqlComando.Parameters.Add("@IdAct", SqlDbType.Int).Value = idAct;
            SqlComando.Parameters.Add("@IdCom", SqlDbType.Int).Value = idCom;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        // REMOVER con ambos idAct y idCom
        public int removerRelacion(int idAct, int idCom)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[ActividadComision] WHERE (idActividad=(@IdAct) AND idComision=(@IdCom)");

            SqlComando.Parameters.Add("@IdAct", SqlDbType.Int).Value = idAct;
            SqlComando.Parameters.Add("@IdCom", SqlDbType.Int).Value = idCom;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        // REMOVER con unicamente idAct
        public int removerRelacionIdAct(int idAct)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[ActividadComision] WHERE idActividad=(@IdAct)");

            SqlComando.Parameters.Add("@IdAct", SqlDbType.Int).Value = idAct;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        // REMOVER con unicamente idCom
        public int removerRelacionIdCom(int idCom)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[ActividadComision] WHERE idComision=(@IdCom)");

            SqlComando.Parameters.Add("@IdCom", SqlDbType.Int).Value = idCom;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }
    }
}
