using System;

namespace MulticastDelegate
{
	public class Program
	{
		public delegate void MyDelegate(double p1, double p2);
		public void PrintArea(double l, double b)
		{
			Console.WriteLine("Area: " + l * b);
		}
		public void PrintPerimeter(double l, double b)
		{
			Console.WriteLine("Perimeter: " + 2 * (l + b));
		}

		public static void Main(string[] args)
		{
			Program p1 = new Program();

			MyDelegate md1 = p1.PrintArea;
			MyDelegate md2 = p1.PrintPerimeter;
			MyDelegate? md3 = md1 + md2;              // Set multiple target methods

			md3(5, 2);                                // Calls both methods
			md3 = md3 - md1;
			md3(6, 3);                                // Calls only one method
			Console.WriteLine();
			Console.WriteLine("Lab No: 9b");
			Console.WriteLine("Name: Giver Khadka");
			Console.WriteLine("Roll No.: 05");
		}
	}
}