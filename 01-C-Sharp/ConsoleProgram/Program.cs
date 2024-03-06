using System;

namespace MyApp
{
	public class Program
	{
		public static void Sum<T>(T a, T b)
		{
			//var n1 = Convert.ToDouble(a);
			//var n2 = Convert.ToDouble(b);
			dynamic n1 = a;
			dynamic n2 = b;
			var res = n1 + n2;
			Console.WriteLine("Sum is: " +  res);
		}

		public static void Main(string[] args)
		{
			Sum<int>(4, 5);
			Sum<float>(4.5f, 5.5f);
		}
	}
}