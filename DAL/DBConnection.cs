using System;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace prueba.DAL
{
    public class DBConnection
    {
        private static readonly string conn_bd = Startup.StaticConfig["ApplicationSettings:ConnectionStrings:IfxConnection"];

        public static MySqlConnection ConexionSql()
        {
            MySqlConnection conSql = new MySqlConnection(conn_bd);

            return conSql;
          
        }
    }
}
