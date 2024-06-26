﻿using _05_CRUD_App_Sir.Models;
using Microsoft.Data.SqlClient;

namespace _05_CRUD_App_Sir.Controllers.Repository
{
    public class StudentRepo
{
    // Write user name from SSMS software
    string conStr = @"server=DESKTOP-JAE0FTL\MSSQLSERVER01; database=GiverDB; Trusted_Connection=True; TrustServerCertificate=True;";
    //string conStr = @"server=YUSHUV-PC\SQLEXPRESS; database=giver; Trusted_Connection=True; TrustServerCertificate=True;";
    // Read Logic
    public List<Student> GetAllRecord()
    {
        List<Student> listOfStudents = new List<Student>();

        try
        {
            // Write user name from SSMS software
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            Console.WriteLine("Connection Established");

            string selectQuery = "SELECT * FROM Students";
            //string selectQuery = "SELECT * FROM Student";
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
                Console.WriteLine("Data Check: ");
                Console.WriteLine(std.Id);
                Console.WriteLine(std.Name);
                Console.WriteLine(std.Address);
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
    // Create Logic
    public void SetStudent(Student s1)
    {
        try
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            Console.WriteLine("Connection Established");

            string selectQuery = $"INSERT INTO Students VALUES({s1.Id}, '{s1.Name}', '{s1.Address}')";
            //string selectQuery = $"INSERT INTO Student VALUES({s1.Id}, '{s1.Name}', '{s1.Address}')";

            SqlCommand sqlcmd = new SqlCommand(selectQuery, conn);
            // 'rdr' stores the result of SQL Query
            int n = sqlcmd.ExecuteNonQuery();
            Console.WriteLine("Record Inserted Successfully");
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error Connecting: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Create Complete");
        }

    }
    // Create Logic using 'using' keyword
    public void SetStudent2(Student s1)
    {
        // 'using' keyword helps to make code clean by automatically closing connection, file streams, etc.
        using (SqlConnection conn = new SqlConnection(conStr))
        {
            conn.Open();
            Console.WriteLine("Connection Established");

            string selectQuery = $"INSERT INTO Students VALUES({s1.Id}, '{s1.Name}', '{s1.Address}')";
            //string selectQuery = $"INSERT INTO Student VALUES({s1.Id}, '{s1.Name}', '{s1.Address}')";

            SqlCommand sqlcmd = new SqlCommand(selectQuery, conn);
            // 'rdr' stores the result of SQL Query
            int n = sqlcmd.ExecuteNonQuery();
            Console.WriteLine("Record Inserted Successfully");

            // Here, no need to manually close connection with 'conn.Close()'
        }
    }
    // View Record
    // Create Logic using 'using' keyword
    public Student ViewRecord(int id)
    {
        // 'using' keyword helps to make code clean by automatically closing connection, file streams, etc.
        using (SqlConnection conn = new SqlConnection(conStr))
        {
            conn.Open();
            Console.WriteLine("Connection Established");

            string selectQuery = $"SELECT * FROM Students WHERE id={id}";
            // string selectQuery = $"SELECT * FROM Student WHERE id={id}";

            SqlCommand sqlcmd = new SqlCommand(selectQuery, conn);
            // 'rdr' stores the result of SQL Query
            int n = sqlcmd.ExecuteNonQuery();
            Console.WriteLine("Record Viewed Successfully");
            Student std = new Student();
            SqlDataReader rdr = sqlcmd.ExecuteReader();
            while (rdr.Read())                      // Just like fallocate() in PHP
            {
                // 'rdr's key is database's table column name
                std.Id = Convert.ToInt32(rdr["id"]);
                std.Name = Convert.ToString(rdr["name"]);
                std.Address = Convert.ToString(rdr["address"]);
            }
			// Good practice to close connection to allow other users to access server 
			conn.Close();
			return std;
        }
    }
    // Edit Logic
    public void EditStudent(int id, string newName, string newAddr)
    {
        try
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            Console.WriteLine("Connection Established");

            string selectQuery = $"UPDATE Students SET name='{newName}', address='{newAddr}' WHERE id={id}";
            //string selectQuery = $"UPDATE Student SET name='{newName}', address='{newAddr}' WHERE id={id}";

            SqlCommand sqlcmd = new SqlCommand(selectQuery, conn);
            // 'n' means number of affected rows
            int n = sqlcmd.ExecuteNonQuery();
            Console.WriteLine("Record Updated Successfully");
            // Good practice to close connection to allow other users to access server 
            conn.Close();
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error Connecting: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Update Complete");
        }
        
    }
    // Delete Logic
    public void DeleteStudent(int id)
    {
        try
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            Console.WriteLine("Connection Established");

            string selectQuery = $"DELETE FROM Students WHERE id={id}";
            //string selectQuery = $"DELETE FROM Student WHERE id={id}";

            SqlCommand sqlcmd = new SqlCommand(selectQuery, conn);
            int n = sqlcmd.ExecuteNonQuery();
            Console.WriteLine("Record Deleted Successfully");
			// Good practice to close connection to allow other users to access server 
			conn.Close();
		}
        catch (SqlException ex)
        {
            Console.WriteLine("Error Connecting: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Delete Complete");
        }

    }
}
}
