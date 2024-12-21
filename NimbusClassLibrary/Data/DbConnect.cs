using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Data
{
    public class DbConnect
    {
        MySqlConnection conn = new MySqlConnection();
        public DbConnect()
        {
            string connString =
                "Data Source = 153.92.15.21;" +
                " Initial Catalog = u936666569_Nimbus;" +
                " Persist Security Info = True;" +
                " User ID = u936666569_Nimbus;" +
                " Password = Haduken@123456;";
            try
            {
                conn.ConnectionString = connString;
                 
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
