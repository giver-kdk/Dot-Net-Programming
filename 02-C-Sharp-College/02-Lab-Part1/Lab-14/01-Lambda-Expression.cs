using System;

namespace LambdaDelegate
{
	public delegate double MyDelegate(double value);
	public class Program
	{
		public static void Main(string[] args)
		{
			double num = 5.6d;
			// Lambda Expression
			MyDelegate md2 = (x) =>
			{
				Console.Write("Square Value is: ");
				return x * x;
			};
			double square = md2(num);
			Console.WriteLine(square);

			Console.WriteLine("Lab No: 14a");
			Console.WriteLine("Name: Giver Khadka");
			Console.WriteLine("Roll No.: 05");
		}
	}
}
