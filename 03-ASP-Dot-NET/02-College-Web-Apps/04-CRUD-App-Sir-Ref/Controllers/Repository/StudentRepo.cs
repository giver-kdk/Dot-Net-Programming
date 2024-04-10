using CRUD_App.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CRUD_App.Controllers.Repository
{
    public class StudentRepo
    {
        public List<Student> GetAllRecord()
        {
            List<Student> listOfStudents = new List<Student>();

            try
            {
                // Write user name from SSMS software
                string conStr = @"server=DESKTOP-JAE0FTL\MSSQLSERVER01; database=GiverDB; Trusted_Connection=True; TrustServerCertificate=True;";
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                Console.WriteLine("Connection Established");

                string selectQuery = "SELECT * FROM Students";
                SqlCommand sqlcmd = new SqlCommand(selectQuery, conn);
                // 'rdr' stores the result of SQL Query
                SqlDataReader rdr = sqlcmd.ExecuteReader();
                Console.WriteLine("Record Retrieved Successfully");

                while (rdr.Read())                      // Just like fallocate() in PHP
                {
                    Student std = new Student();
                    // 'rdr's key is database's table column name
                    std.Id = Convert.ToInt32(rdr["id"]);
                    std.Name = Convert.ToString(rdr["name"]);
                    std.Address = Convert.ToString(rdr["address"]);
                    listOfStudents.Add(std);            // Add DB record in the list
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Connecting: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Read Complete");
            }

            return listOfStudents;
        }
    }
}
