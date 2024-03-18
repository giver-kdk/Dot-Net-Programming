using System;
using System.Collections;
// 'IEnumerable' interface allows non-generic collection or class to be iterable
// The interface includes 'GetEnumerator()' method that need to be implemented for iteration
namespace EnumerablesApp
{
	public class Animal
	{
		public string Name { get; set; }
		public int Weight { get; set; }
	}
	// Making the class iterable
	public class AnimalFarm : IEnumerable
	{
		// List of animal class objects
		public List<Animal> Animals = new List<Animal>() {
			new Animal{Name = "Dog", Weight = 10},
			new Animal{Name = "Cat", Weight = 6},
			new Animal{Name = "Mouse", Weight = 2}
		};

		// Implement the 'IEnumerable' interface method
		public IEnumerator GetEnumerator()
		{
			// When iterating through class object, return iteration of the 'Animals' list
			return Animals.GetEnumerator();
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			AnimalFarm af = new AnimalFarm();
			// Iterating through class like an array
			foreach (Animal a in af)
			{
				// Since, we get 'Animals' list iteration. So, access the fields
				Console.WriteLine(a.Name);
				Console.WriteLine(a.Weight);
			}
		}
	}
}
