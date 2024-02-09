using System;

namespace PrivateConstructor
{
	public class Animal
	{
		public string name;
		public string sound;
		// Writing this much only is enough to only allow this class to create object
		// Not even the child class can use this class to create objects
		private Animal() { }
		public Animal(string name, string sound)
		{
			this.name = name;
			this.sound = sound;
		}
	}
	public class Program
	{
		public static void Main()
		{
			//Animal dog = new Animal();			// This is not allowed due to private constructor

			Animal dog = new Animal("Shaggy", "Bhow");
			Console.WriteLine(dog.name);
			Console.WriteLine(dog.sound);
		}
	}
}