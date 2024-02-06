using System;

namespace MathUtility
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Math field
			Console.WriteLine("Value of PI: {0}", Math.PI);
			Console.WriteLine("Value of e: {0}", Math.E);
			Console.WriteLine("Value of Tau: {0}", Math.Tau);
			// Math methods don't change the original variable
			float num1 = 5.468f;
			int num2 = 16;
			double num3 = 3;
			int num4 = -45;
			Console.WriteLine("Rounded Value: {0}", Math.Round(num1));
			Console.WriteLine("Floored Value: {0}", Math.Floor(num1));
			Console.WriteLine("Ceiled Value: {0}", Math.Ceiling(num1));
			Console.WriteLine("Square Root of {0}: {1}", num2, Math.Sqrt(num2));
			Console.WriteLine("Cube of {0}: {0}", num3, Math.Pow(num3, 3));
			Console.WriteLine("Absolute of {0}: {1}", num4, Math.Abs(num4));
			Console.WriteLine("Log of 100: {0}", Math.Log(Math.E));
			Console.WriteLine("Max Value: {0}", Math.Max(20, 80));
			Console.WriteLine("Min Value: {0}", Math.Min(20, 80));
			// Trigonometric Methods
			Console.WriteLine("Sin Value: {0}", Math.Sin(30));
			Console.WriteLine("Cos Value: {0}", Math.Cos(30));
			Console.WriteLine("Tan Value: {0}", Math.Tan(30));

		}
	}
}