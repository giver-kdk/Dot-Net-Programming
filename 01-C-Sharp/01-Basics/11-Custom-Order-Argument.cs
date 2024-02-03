using System;

namespace CustomOrder
{
	public class Program
	{
		static void PrintInfo(string name, int age)
		{
			Console.WriteLine("Person name is {0} and age is {1}.", name, age);
		}
		static void Main(string[] args)
		{
			// Default order argument
			PrintInfo("Giver", 21);

			// Custom order argument
			PrintInfo(age: 22, name: "Smith");
			// PrintInfo(22, "Smith");		// This wont work
		}
	}
}