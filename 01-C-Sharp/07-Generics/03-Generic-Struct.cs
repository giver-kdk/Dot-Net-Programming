using System;
using System.Collections.Generic;

namespace GenercStructApp
{
	public class Program
	{
		// Generic 'struct' is same as Generic 'Class'
		// Put the unknown type after struct name
		public struct Shape<T>
		{
			public T l;
			public T b;
			// Using the unknown type 'T' specified in the struct 
			public void ShowArea()
			{
				// double length = (double) l;					// This type casting is not compatible
				double length = Convert.ToDouble(l);            // Converting 'T' to 'double'
				double breadth = Convert.ToDouble(b);
				//Console.WriteLine($"Area is {l * b}");		// Can't perform operation on unknown data types 
				Console.WriteLine($"Area is {length * breadth}");
			}
		}
		public static void Main(string[] args)
		{
			Shape<int> rect = new Shape<int>();
			rect.l = 5;
			rect.b = 4;

			rect.ShowArea();


			Shape<float> rect2 = new Shape<float>();
			rect2.l = 3.5f;
			rect2.b = 2.5f;

			rect2.ShowArea();


			Shape<double> rect3 = new Shape<double>();
			rect3.l = 10.5d;
			rect3.b = 5.5d;

			rect3.ShowArea();
		}
	}
}