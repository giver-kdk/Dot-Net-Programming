using System;
// Needed to use 'StringBuilder' class
using System.Text;

namespace StrigBuilder
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Creating String Builder. Default capacity is 16 characters
			StringBuilder sb = new StringBuilder("Hello.");
			Console.WriteLine(sb);
			Console.WriteLine("Capacity 1: {0}", sb.Capacity);			// Total capacity
			Console.WriteLine("Length 1: {0}", sb.Length);			// Used capacity
			Console.WriteLine();

			// Creatig String Builder with custom capacity
			StringBuilder sb2 = new StringBuilder("Bye.", 20);
			Console.WriteLine("Capacity 2: {0}", sb2.Capacity);
			Console.WriteLine();

			// Add new text and automatically put '\n' at end like 'WriteLine()'
			sb.AppendLine(" I am a student.");
			Console.WriteLine("Append Line: {0}", sb);
			Console.WriteLine();

			// Add new text. 
			sb.Append("I study CSIT.");
			Console.WriteLine("Append: {0}", sb);
			Console.WriteLine();

			// Replace substring in String Builder 
			sb.Replace("CSIT", "Computer");
			Console.WriteLine("Replace: {0}", sb);
			Console.WriteLine();

			// Remove substring in from start index to ending index 
			sb.Remove(0, 7);			// String from index 0-7 removed
			Console.WriteLine("Remove: {0}", sb);
			Console.WriteLine();

			// Insert substring from specified position
			sb.Insert(25, "about ");
			Console.WriteLine("Insert: {0}", sb);
			Console.WriteLine();

			// Compare String Builders
			Console.WriteLine(sb == sb2);
			Console.WriteLine();

			// Clearing the entire String Builder
			sb.Clear();
			Console.WriteLine("Clear: {0}", sb);		// Empty Screen
		}
	}
}