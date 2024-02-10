using System;
using System.Reflection.Metadata.Ecma335;

// When constructor overloading, we might need to redo the same thing in one constructor
// that has already been done in another constructor

// This repeatation can be avoided using 'Constructor Chaining'
namespace ConsoleApp
{
	public class Rectangle
	{
		public int length;
		public int breadth;

		// Default Constructor
		public Rectangle(int length, int breadth)
		{
			this.length = length;
			this.breadth = breadth;
		}
		// When only 1 parametered constructor called by user, 
		// 'this()' calls the constructor with 2 parameters
		// Then 1 parametered constructor does it's logic
		public Rectangle(int length) : this(length, 10)
		{
			// Here, we don't have to repeat the logic for 'breadth'
			Console.WriteLine("Default Breadth set to 10");
		}

		// When non-parametered constructor called by user, 
		// 'this()' first reuses the 1 parametered constructor(Making Chain)
		// Then non-parametered constructor does it's logic
		public Rectangle() : this(10)
		{
			Console.WriteLine("Default Length and Breadth set to 10");
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			Rectangle r1 = new Rectangle(2, 4);
			Console.WriteLine("Length: {0}\nBreadth: {1}", r1.length, r1.breadth);

			Rectangle r2 = new Rectangle(5);
			Console.WriteLine("Length: {0}\nBreadth: {1}", r2.length, r2.breadth);

			Rectangle r3 = new Rectangle();
			Console.WriteLine("Length: {0}\nBreadth: {1}", r3.length, r3.breadth);
		}
	}
}