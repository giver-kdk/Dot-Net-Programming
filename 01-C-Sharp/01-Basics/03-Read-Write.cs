using System;

namespace ReadWrite
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Output without ending with new line
			Console.Write("Enter your first name: ");
			// Read entire line as user input and store in 'name'
			string fName = Console.ReadLine();
			Console.Write("Enter your last name: ");
			string lName = Console.ReadLine();
			// Console.WriteLine($"Hello {name}");		// Supported in C# >= 6.0 
			// Here, inside '{}', we write 0, 1, 2, 3,... to specify order of variables 
			Console.WriteLine("Hello {0} {1}", fName, lName);
			Console.WriteLine("Hello " + fName + " " + lName);
		}
	}
}