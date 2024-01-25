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
			#pragma warning disable CS8600
			// Converting null literal or possible null value to non-nullable type.
			string name = Console.ReadLine();
			// Converting null literal or possible null value to non-nullable type.
			Console.WriteLine($"Hello {name}");
			Console.WriteLine("Hello {0}", name);
			Console.WriteLine("Hello " + name);
		}
	}
}