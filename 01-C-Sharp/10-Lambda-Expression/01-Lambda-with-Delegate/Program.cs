using System;

namespace LambdaDelegate
{
	public class Program
	{
		public static void Main(string[] args)
		{
			double num = 5.6d;
			// Lambda Expression is like fat arrow function in JS
			// Types:  Statement Lambda and Expression Lambda
			// Statement Lambda allows to write multiple statements
			MyDelegate md2 = (x) =>
			{
				Console.Write("Square Value is: ");
				return x * x;
			};
			double square = md2(num);
			Console.WriteLine(square);

			// Expression Lambda allows to returns result in one line without 'return' keyword
			MyDelegate md = x => x * x;

			num = 10.5d;
			square = md(num);
			Console.WriteLine(square);
		}
	}
}
