using System;

namespace VirtualMethod
{
	public class Animal
	{
		public string Name { get; set; }
		public string Sound { get; set; }

		public Animal(string n, string s)
		{
			Name = n;
			Sound = s;
		}
		// Virtual Methods can be overwritten by child class Methods
		public virtual void ProduceSound()
		{
			Console.WriteLine("Animal Sound is: {0}", Sound);
		}
	}
	public class Dog : Animal
	{
		public string Breed { get; set; }

		public Dog(string n, string s, string b) : base(n, s)
		{
			Breed = b;
		}
		// Overwriting virtual function of parent class
		public override void ProduceSound()
		{
			//base.ProduceSound();						// Runs base clas's virtual function if needed to avoid repition
			Console.WriteLine("Dog Sound is: {0}", Sound);
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Animal a1 = new Animal("Mika", "Meow");
			a1.ProduceSound();

			Dog d1 = new Dog("Lucy", "Bhow", "Husky");
			d1.ProduceSound();
		}
	}
}