using System;

namespace LambdaDelegate
{
	public delegate int MyDelegate(int value);          // Delegate
	public class Program
	{
		public static void Main(string[] args)
		{
			// Statement Lambda allows to write multiple statements
			MyDelegate md2 = (x) =>
			{
				Console.Write("Square Value is: ");
				return x * x;
			};
			int square = md2(5);
			Console.WriteLine(square);

			// Expression Lambda allows to returns result in one line without 'return' keyword
			MyDelegate md = x => x * x;

			square = md(10);
			Console.WriteLine(square);
		}
	}
}
