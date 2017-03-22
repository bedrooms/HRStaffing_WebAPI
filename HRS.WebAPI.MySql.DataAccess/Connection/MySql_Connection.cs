using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;

namespace HRS.WebAPI.MySql.DataAccess.Connection
{
    [DataObject(true)]
    public static class MySql_Connection
    {
        /// <summary>
        /// Returns current database connection
        /// </summary>
        /// <returns>Connection</returns>
        public static string getConnection()
        {
            return ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
            
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static object GetMessages()
        {
            MySqlCommand cmd = new MySqlCommand("getAllJobs", new MySqlConnection(getConnection()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return new object();
        }
    }
}
