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
        public void ConnectToDB()
        {
            SqlConnection conn = null;
            try
            {
                // Write user name from SSMS software
                string conStr = @"server=DESKTOP-JAE0FTL\MSSQLSERVER01; database=GiverDB; Trusted_Connection=True; TrustServerCertificate=True;";
                conn = new SqlConnection(conStr);
                conn.Open();
                Console.WriteLine("Connection Established");
                int id = 1;
                string name = "Giver";
                string address = "Thulobharyang";
                int phone = 981159800;

                string query = "INSERT INTO Students VALUES(" + name + ", " + address + ", " + phone + ")";
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                int n = sqlcmd.ExecuteNonQuery();
                Console.WriteLine(n + " Record Inserted Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Connecting: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Task Complete");
            }
        }
        public void ReadDB()
        {
            SqlConnection conn = null;
            try
            {
                // Write user name from SSMS software
                string query = "SELECT * FROM Students";
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                int n = sqlcmd.ExecuteNonQuery();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                Console.WriteLine("Reading Database");
                while(reader.Read())
                {
                    Console.WriteLine(reader["Name"]);
                    Console.WriteLine(reader["Address"]);
                    Console.WriteLine(reader["Phone"]);
                }
                Console.WriteLine("All records are fetched");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Connecting: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Read Complete");
                conn.Close();
            }
        }
    }
}
