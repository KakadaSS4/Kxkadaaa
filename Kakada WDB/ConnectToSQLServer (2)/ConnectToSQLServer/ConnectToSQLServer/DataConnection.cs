using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToSQLServer
{
    internal class DataConnection
    {
        public static SqlConnection sCon { get; set; }
        public static string Seller { get; set; }
        /// <summary>
        /// Authentication
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        public static void ConnectDB(string serverName, string databaseName)
        {
            string connectionString = "Server=" + serverName + "; Database=" + databaseName + "; Trusted_Connection=True";
            sCon = new SqlConnection(connectionString);
            sCon.Open();
            Seller = Environment.UserName;
        }
        /// <summary>
        /// SQL Server Authentication
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public static void ConnectDB(string serverName, string databaseName, string userName, string password)
        {
            string connectionString = "Server=" + serverName + "; Database=" + databaseName + "; User Id=" + userName + "; Password=" + password;
            sCon = new SqlConnection(connectionString);
            sCon.Open();
            Seller = userName;
        }
    }
}
