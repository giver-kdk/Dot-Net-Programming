using System;

namespace AnimalNamespace
{
	public class Animal
	{
		// Initialization is allowed
		public string name = "No name";
		public string sound;
		// 'static' field value persists
		public static int count = 0;

		// Constructor doens't return anything
		public Animal()
		{
			sound = "No sound";
			count++;
		}
		public Animal(string name, string sound)
		{
			// Use 'this' when parameter same as field name
			this.name = name;
			this.sound = sound;
			count++;
		}
		public void GetSound()
		{
			Console.WriteLine("Animal {0} has sound {0}", name, sound);
		}
		public static void PrintCount()
		{
			// 'static' field only accessible by 'static' method
			Console.WriteLine("Total number of object: {0}", count);
		}
	}
}
