// Mehtod Overloading is simply 'Polymorphism'
// Methods with same name but different type or different number of parameters is Method Overloading
using System;

namespace MethodOverload
{
	public class Program
	{
		static void Add(int a, int b)
		{
			Console.WriteLine("Sum is {0}", a + b);
		}
		static void Add(string a, string b)
		{
			Console.WriteLine("Concatinated string is {0}", a + b);	
		}
		static void Multiply(int a, int b)
		{
			Console.WriteLine("Product is {0}", a * b);
		}
		static void Multiply(int a, int b, int c)
		{
			Console.WriteLine("Product is {0}", a * b * c);
		}
		static void Main(string[] args)
		{
			// Method overloading with different data types
			Add(2, 3);
			Add("Giver ", "Khadka");

			// Method overloading with different number of parameters
			Multiply(4, 5);
			Multiply(4, 5, 6);
		}
	}
}