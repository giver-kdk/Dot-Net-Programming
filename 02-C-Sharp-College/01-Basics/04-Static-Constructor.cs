using System;

namespace StaticCOnstructor
{
	public class Animal
	{
		public string name;
		public static int count;

		// Static Constructor automatically runs even before the 'Main()' function 
		// It runs only once to initialize the class
		// There is no access modifier or parameters in static constructor
		static Animal()
		{
			Console.WriteLine("Start of Static Constructor");
			count = 400;
		}
		public Animal()
		{
			Console.WriteLine("Start of Default Constructor");
			name = "No Name";
			count++;
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("Start of Main Function");
			Animal dog = new Animal();
			dog.name = "Bluty";

			Console.WriteLine("Animal Name: {0}", dog.name);
			Console.WriteLine("Animal Count: {0}", Animal.count);
		}
	}
}