using System;

namespace PrintArray
{
	public class Program 
	{
		static void Main(string[] args)
		{
			string[] names = {"Ram", "Shyam", "Hari"};
			
			// Syntax: foreach(<data_type> <element> in <array>) {}
			// Array Traversal 
			foreach(string name in names)
			{
				Console.WriteLine(name);
			}

			// Also works in case of object type array
			object[] person = {"Giver", 19, "Nepal"};
			Console.WriteLine();
			foreach(object info in person)
			{
				Console.WriteLine(info);
			}
		}
	}
}