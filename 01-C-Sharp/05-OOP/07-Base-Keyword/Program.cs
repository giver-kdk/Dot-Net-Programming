// Previously, we use 'base' keyword to call parent constructor
// We can also use it to access parent methods and fields
// Checkout 'Car.cs' for the example
using System;

namespace BaseKeyword
{
	public class Program
	{
		static void Main(string[] args)
		{
			Car c1 = new Car("Lamborgini", 280, 4);
			c1.ShowInfo();
		}
	}
}