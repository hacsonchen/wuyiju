using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Core
{

    public static class ConnectionFactory
    {
        private static readonly string connectionName = ConfigurationManager.AppSettings["SQLDialect"];
        private static readonly string connString = ConfigurationManager.ConnectionStrings["ZhiMaKaiMen"].ConnectionString;

        public static IDbConnection CreateConnection()
        {

            IDbConnection connection;

            switch (connectionName)
            {
                case "SQLServer":
                    connection = new SqlConnection(connString);
                    break;
                case "MySQL":
                    connection = new MySqlConnection(connString);
                    break;
                //case "Oracle":
                //    conn = new OracleConnection(connString);
                default:
                    connection = new MySqlConnection(connString);
                    break;
            }


            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }

    }
}
