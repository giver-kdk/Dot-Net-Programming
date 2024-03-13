using System;
using System.Collections.Generic;
// 'ArrayList' is deprecated and 'List' is the newer update
namespace ListApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<string> people = new List<string>();   // Creating 'List' of string data type
			people.Add("Ram");                          // Inserting element in List
			people.Add("Shyam");
			people.Add("Hari");

			people.Insert(1, "Gopal");                  // Insert element at specified index

			Console.WriteLine(people.Count);            // Output: 4
														// Check for particular element in the List
			Console.WriteLine(people.Contains("Ram"));  // Output: True
			Console.WriteLine(people.IndexOf("Shyam")); // Output: 2

			people.RemoveAt(2);                         // Deleting element from specified index
														// List Traversal same as Array Traversal
			foreach (string str in people)
			{
				Console.WriteLine(str);
			}
		}
	}
}
