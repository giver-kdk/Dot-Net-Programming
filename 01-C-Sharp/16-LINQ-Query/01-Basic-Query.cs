using System;

namespace LINQQUeryApp
{
	public class Program
	{
		class Animal
		{
			public string Name { get; set; }
			public int Age { get; set; }
		}
		public static void Main(string[] args)
		{
			List<Animal> animals = new List<Animal>() {
				new Animal {Name = "Dog", Age = 10},
				new Animal {Name = "Cat", Age = 6},
				new Animal {Name = "Mouse", Age = 2},
				new Animal {Name = "Parrot", Age = 1},
				new Animal {Name = "Horse", Age = 11},
			};
			// LINQ Query to extract items from list according to condition 
			var res = from anim in animals
					  where (anim.Age > 5 && anim.Age < 15)
					  select anim;
			// Converting query result into list for iteration
			var listRes = res.ToList<Animal>();
			foreach (var item in listRes)
			{
				Console.WriteLine(item.Name);
				Console.WriteLine(item.Age);
			}
		}
	}
}
