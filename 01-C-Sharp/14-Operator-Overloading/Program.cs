using System;
using System.Runtime.CompilerServices;

namespace OperatorOverloadApp
{
	public class Box
	{
		public int Length { get; set; }
		public int Breadth { get; set; }
		public int Height { get; set; }

		public Box(int l, int b, int h)
		{
			Length = l;
			Breadth = b;
			Height = h;
		}
		public Box() : this(1, 1, 1) { }

		// Define what '+' does with 'b1' and 'b2' objects
		// Here, '+' adds respective fields and returns new 'Box' object
		// 'static' is needed to allow operator overloading without creating object instance
		public static Box operator +(Box b1, Box b2)                // Addition			
		{
			return new Box
			{
				Length = b1.Length + b2.Length,
				Breadth = b1.Breadth + b2.Breadth,
				Height = b1.Height + b2.Height
			};
		}
		public static Box operator -(Box b1, Box b2)                // Subtraction
		{
			return new Box
			{
				Length = b1.Length - b2.Length,
				Breadth = b1.Breadth - b2.Breadth,
				Height = b1.Height - b2.Height
			};
		}
		// NOTE: '==' operator overloading requires '!=' overloading to be defined as well
		public static bool operator ==(Box b1, Box b2)               // Equality Check
		{
			if (b1.Length == b2.Length &&
			b1.Breadth == b2.Breadth &&
			b1.Height == b2.Height)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static bool operator !=(Box b1, Box b2)               // Inequality Check
		{
			if (b1.Length != b2.Length ||
			b1.Breadth != b2.Breadth ||
			b1.Height != b2.Height)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// We can also overload the 'ToString()' method for the class
		public override string ToString()
		{
			// Convert the object to string
			string value = String.Format($"Box Length: {Length}\nBox Breadth: {Breadth}\nBox Height: {Height}");
			return value;
		}

		// We can define how the type conversion happens
		// Explicit conversion of 'Box' to 'int'
		public static explicit operator int(Box b1)
		{
			return (b1.Length + b1.Breadth + b1.Height);        // Return type is automatically 'int'
		}
		// Implicit conversion of 'int' to 'Box'
		public static implicit operator Box(int i)
		{
			return new Box(i, i, i);                            // Return type is automatically 'Box'
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Box b1 = new Box(20, 10, 5);
			Box b2 = new Box(30, 20, 15);
			// Using 'Addition' operator overloading
			Box b3 = b1 + b2;
			Console.WriteLine(b3.ToString());                   // Using overridden 'ToString' for object data

			// Using 'Equality' operator overloading
			if (b1 == b2)
			{
				Console.WriteLine("Boxes are euqal");
			}
			else
			{
				Console.WriteLine("Boxes are not equal");
			}
			// Using 'Type Conversion' overloading
			Console.WriteLine((int)b3);                     // Explicit Conversion 

			Console.WriteLine((Box)4);                         // Implicit Conversion 
		}
	}
}
