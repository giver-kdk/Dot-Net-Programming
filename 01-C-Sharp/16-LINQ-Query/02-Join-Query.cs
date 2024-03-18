using System;

namespace InnerJoinApp
{
	public class Program
	{
		class Animal
		{
			public string Name { get; set; }
			public int Age { get; set; }
			public int ID { get; set; }
		}
		class Owner
		{
			public string Name { get; set; }
			public int ID { get; set; }
		}
		public static void Main(string[] args)
		{
			List<Animal> animals = new List<Animal>() {
				new Animal {Name = "Dog", Age = 10, ID = 1},
				new Animal {Name = "Cat", Age = 6, ID = 2},
				new Animal {Name = "Mouse", Age = 2, ID = 1},
				new Animal {Name = "Parrot", Age = 1, ID = 3},
				new Animal {Name = "Horse", Age = 11, ID = 2}
			};
			List<Owner> owners = new List<Owner>() {
				new Owner {Name = "Alex", ID = 1},
				new Owner{Name = "Micheal", ID = 2},
				new Owner {Name = "John", ID = 3}
			};
			// LINQ Query to extract items from list according to condition 
			// This is inner join and it might have repeatations
			var res = from anim in animals
					  join owner in owners
					on anim.ID equals owner.ID
					  select new { OwnerName = owner.Name, AnimalName = anim.Name };
			// Converting query result into list for iteration
			foreach (var item in res)
			{
				Console.Write(item.OwnerName + ": ");
				Console.WriteLine(item.AnimalName);
			}
		}
	}
}
