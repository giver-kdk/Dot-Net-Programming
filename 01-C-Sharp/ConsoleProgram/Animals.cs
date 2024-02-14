using System;

namespace SealedClass
{
	public class Animal
	{
		public string Name { get; set; }

		public Animal(string n)
		{
			Name = n;
		}

		public virtual void ShowInfo()
		{
			Console.WriteLine("Animal name: {0}", Name);
		}
	}
	// ************ Sealed Class *********************
	// Even though 'Dog' was inheritated from 'Animal' 
	// But, now no other class can inherit from 'Dog'
	public sealed class Dog : Animal
	{
		public string Sound { get; set; }
		public Dog(string n, string s) : base(n)
		{
			Sound = s;
		}
		public override void ShowInfo()
		{
			Console.WriteLine("Dog name: {0}", Name);
			Console.WriteLine("Dog sound: {0}", Sound);
		}
	}
	public class Cat : Animal
	{
		public string Sound { get; set; }
		public Cat(string n, string s) : base(n)
		{
			Sound = s;
		}
		// ************ Sealed Method *********************
		// Even though 'Cat's 'ShowInfo()' overrides 'Animal's 'ShowInfo()' 
		// But, now no other 'Cat's child class can override 'Cat's 'ShowInfo()'
		public sealed override void ShowInfo()
		{
			Console.WriteLine("Cat name: {0}", Name);
			Console.WriteLine("Cat sound: {0}", Sound);
		}

	}
	public class Kitten : Cat
	{
		public int Age { get; set; }
		public Kitten(string n, string s, int a) : base(n, s)
		{
			Age = a;
		}
		// 'Cat's child class cannot override 'Cat's 'ShowInfo()'
		//public sealed override void ShowInfo(){}

	}
}