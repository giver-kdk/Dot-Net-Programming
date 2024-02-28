using System;
// 'List' is located in 'Generic' namespace
using System.Collections.Generic;
// 'List' is similar to 'ArrayList' but it is more Type Safe
// 'List' is Generic. So, we can set desired data type for the collection
// Once, data type is set. It is applied to all the elements of 'List' unlike 'ArrayList'
// 'ArrayList' is deprecated and 'List' is the newer update

namespace ListApp
{
	public class Student                    // Simple Class
	{
		public string? Name { get; set; }
		public int Age { get; set; }
		public void ShowInfo()
		{
			Console.WriteLine($"Student {Name} is {Age} years old");
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			// Creating 'List' of primitive data type
			List<string> people = new List<string>();
			people.Add("Ram");              // Inserting element in List
			people.Add("Shyam");
			people.Add("Hari");
			//people.Add(123);				// This is not allowed cause we created 'List' of type 'string'

			people.Insert(1, "Gopal");      // Insert element at specific index
			string[] group = { "Alex", "John", "Smith" };
			people.InsertRange(1, group);   // Insert multiple elements at specific index

			people.RemoveAt(2);             // Deleting element at specific index from List

			Console.WriteLine(people.Count);    // List Length
												// Check for particular element in the List
			Console.WriteLine($"List has Ram: {people.Contains("Ram")}");
			Console.WriteLine($"Shyam index is: {people.IndexOf("Shyam")}");
			Console.WriteLine();

			people.Sort();
			Console.WriteLine("Sorted List:");
			// List Traversal same as Array Traversal
			foreach (string str in people)
			{
				Console.WriteLine(str);
			}
			Console.WriteLine();

			people.Reverse();
			Console.WriteLine("Reversed List:");
			foreach (string str in people)
			{
				Console.WriteLine(str);
			}
			Console.WriteLine();




			// List of 'Class' type. This stores array of 'Student' objects
			List<Student> s1 = new List<Student>();
			s1.Add(new Student { Name = "Ram", Age = 21 });
			s1.Add(new Student { Name = "Shyam", Age = 19 });
			s1.Add(new Student { Name = "Hari", Age = 22 });

			foreach (Student s in s1)
			{
				s.ShowInfo();
			}
		}
	}
}
