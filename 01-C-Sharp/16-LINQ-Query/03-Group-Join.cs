using System;

// Group Join preserves all the elements of first list/sequence and 
// searches for their matching elements in second list/sequence and 
// groups the matched result to individual element of first sequence
namespace GroupJoinApp
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
			// This is group join and it doesn't have repeatations
			var res = from owner in owners
					  join anim in animals
					on owner.ID equals anim.ID into ownerAnimalGroup
					  select new
					  {
						  OwnerName = owner.Name,
						  // Here, 'nestAnim' is the matched animal(2nd list) with owner(1st list)
						  AnimalGroup = from nestAnim in ownerAnimalGroup select nestAnim
					  };

			// Herem the order matters! This query preserves 'animals' elements and searches for 
			// matching owners instead
			//var res2 = from anim in animals join owner in owners 
			//			on anim.ID equals owner.ID into ownerAnimalGroup
			//			select new
			//			{
			//			  AnimalName = anim.Name,
			//			  // Here, 'nestAnim' is the matched animal(2nd list) with owner(1st list)
			//			  OwnerGroup = from nestOwner in ownerAnimalGroup select nestOwner
			//			};

			//Result Traversal
			foreach (var item in res)
			{
				Console.WriteLine(item.OwnerName + ": ");
				foreach (var ownAnimal in item.AnimalGroup)
				{
					Console.WriteLine("* " + ownAnimal.Name);
				}
			}

		}
	}
}
