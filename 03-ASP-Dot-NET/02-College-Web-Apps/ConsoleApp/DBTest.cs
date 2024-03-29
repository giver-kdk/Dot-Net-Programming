using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    internal class DBTest
    {
        static void Connect()
        {
            SqlConnection conn = null;
            try
            {   
                // Write user name from SSMS software
                string conStr = @"server=DESKTOP-JAE0FTL\MSSQLSERVER01; database=MyDB; Trusted_Connection=True;";
                conn = new SqlConnection(conStr);
                conn.Open();
                Console.WriteLine("Connection Established");
                int id = 1;
                string name = "Giver";
                string address = "Thulobharyang";
                long phone = 981159800;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
