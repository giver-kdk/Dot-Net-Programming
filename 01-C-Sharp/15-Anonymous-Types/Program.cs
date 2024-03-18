using System;
// Anonymous Types allows us to create object without specifying type/class names
namespace AnonymousTypesApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Object with no class. Just fields
			var dog = new { Name = "Lucy", Age = 6 };
			var cat = new { Name = "Mika", Age = 4 };
			var mouse = new { Name = "Micky", Age = 5 };

			// Array of no data type. Just similar elements with same fields
			var animals = new[] { dog, cat, mouse };

			foreach (var a in animals)
			{
				Console.WriteLine(a.Name);
				Console.WriteLine(a.Age);
			}
		}
	}
}
