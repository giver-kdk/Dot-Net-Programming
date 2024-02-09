using System;

namespace CopyConstrcutor
{
	public class Animal
	{
		public string name;
		public string sound;
		public Animal()
		{
			name = "No Name";
			sound = "No Sound";
		}
		public Animal(string name, string sound)
		{
			this.name = name;	
			this.sound = sound;
		}
		// Copy Constructor: Has only 1 parameter of same class object
		public Animal(Animal obj)
		{
			name = obj.name;
			sound = obj.sound;
		}

		public static void Main(string[] args)
		{
			Animal dog = new Animal("Lucy", "Bhow");
			Animal puppy = dog;

			Console.WriteLine("Object name: {0}", puppy.name);
			Console.WriteLine("Object sound: {0}", puppy.sound);

			Console.WriteLine("Copied Object name: {0}", puppy.name);
			Console.WriteLine("Copied Object sound: {0}", puppy.sound);
		}
	}
}