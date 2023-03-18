using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connectToSQLserver
{
    internal class DataConnection
    {
        public static SqlConnection sCon { get; set; }
        public static string Seller { get; set; }
        public static string UserName { get; private set; }

        /// <summary>
        /// Windows Athentication
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="dbName"></param>
        public static void ConnectDB(string serverName,string dbName)
        {
            string connectionString = "Server=" + serverName +"; Database=" + dbName + "; Trusted_Connection=True";
            sCon=new SqlConnection(connectionString);
            sCon.Open();
            //run yk user name from window
            Seller = Environment.UserName;
        }
        /// <summary>
        /// SQL Server Authentication
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="dbName"></param>
        /// <param name="uName"></param>
        /// <param name="pword"></param>
        public static void ConnectDB(String serverName, string dbName, string uName, string pword)
        {
            string connectionString = "Server=" + serverName + "; Database="
                + dbName + "; User ID=" + uName + "; Password=" + pword;
            sCon=new SqlConnection (connectionString);
            sCon.Open();
            Seller = uName;
        }
    }

}
   
