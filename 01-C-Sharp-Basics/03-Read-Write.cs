using System;

namespace ReadWrite
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Output without ending with new line
			Console.Write("Enter your name: ");
			// Read entire line as user input and store in 'name'
			string name = Console.ReadLine();
			// Console.WriteLine($"Hello {name}");		// Supported in C# >= 6.0 
			// Here, inside '{}', we write either 0 or 1
			Console.WriteLine("Hello {0}", name);
			Console.WriteLine("Hello " + name);
		}
	}
}