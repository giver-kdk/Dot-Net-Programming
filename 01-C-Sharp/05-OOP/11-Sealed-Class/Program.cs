// 'sealed' protects the class from being inheritated
// 'sealed' protects the method/property from being overridden
using System;

namespace SealedClass
{
	public class Program
	{
		public static void Main(string[] args) 
		{
			Animal a1 = new Animal("Mammal");
			a1.ShowInfo();
			// No other class can inherit from 'Dog' because it is 'sealed'
			Dog d1 = new Dog("Lucy", "Bhow");
			d1.ShowInfo();
			
			Cat c1 = new Cat("Mika", "Meow");
			c1.ShowInfo();

			Kitten k1 = new Kitten("Keo", "Weow", 1);
			// Since, 'Cat' has sealed 'ShowInfo()'. So, 'Kitten' cannot override it
			// SO, 'Kitten' uses 'Cat's implementation of 'ShowInfo()' 
			k1.ShowInfo();
		}
	}
}