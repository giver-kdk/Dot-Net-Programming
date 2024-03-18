using System;
using System.Collections.Generic;
using System.Linq;                  // Location of LINQ
// LINQ(Language Integrated Query) allows data access of all data types
/*
    LINQ Types:     
        - LINQ to Object                    // Belongs to Language
        - LINQ to XML                       // Important
        - LINQ to SQL                       // Important
        - LINQ to Database
        - LINQ to Entities
 */
namespace LINQApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<string> courses = new List<string>()
			{
				"C# Tutorial",
				"JS Tutorial",
				"Python",
				"JAVA",
				"Rust Tutorial"
			};
			// The LINQ Query returns 'IEnumerable<T>'. We can also use 'var' as 'result' type for ease
			IEnumerable<string> result = from s in courses where s.Contains("Tutorial") select s;
			// Iterating through 'IEnumerable'
			foreach (string res in result)
			{
				Console.WriteLine(res);
			}
		}
	}
}