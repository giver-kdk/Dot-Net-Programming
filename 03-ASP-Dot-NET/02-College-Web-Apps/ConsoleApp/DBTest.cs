﻿using Microsoft.Data.SqlClient;
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
                string conStr = @"server=DESKTOP-JAE0FTL\MSSQLSERVER01; database=MyDB; Trusted_Connection=True; user-id=giver; password=hello123;";
                conn = new SqlConnection(conStr);
                conn.Open();
                Console.WriteLine("COnnection Established");
                int id = 1;
                string name = "Giver";
                string address = "Thulobharyang";
                long phone = 981159800;
            }
        }
    }
}
