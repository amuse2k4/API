using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ModeTransAPI
{
    public class DatabaseConnection
    { 

        public DatabaseConnection()
        {
            SqlConnection myConnection = new SqlConnection();

            SqlConnectionStringBuilder myBuilder = new SqlConnectionStringBuilder();

            myBuilder.UserID = "amuse";

            myBuilder.Password = "Washington2";

            myBuilder.DataSource = "master";

            myConnection.ConnectionString = myBuilder.ConnectionString;
        }
        
        
    }
}