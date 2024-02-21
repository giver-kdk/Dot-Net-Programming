// During method overriding, the parent class method simple gets Extended
// And corresponsing method implementation runs based upon who is calling(parent or childs)
// The overridden methods still belongs to parent class (It stores the pointers to all the implementations)

// During method hiding(aka Method Shadowing), the parent class method gets hidden/invisible
// And a new method implementation is defined in the child class
// The new method will belong to child class only (New method won't have any relation with parent class method)
using System;

namespace MethodHiding
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Vehicle v1 = new Vehicle("Lambo");
			v1.Greet();
			v1.ShowInfo();
			Console.WriteLine();

			Car c1 = new Car("BMW", 4);
			c1.ShowInfo();
			Console.WriteLine();

			// If we create base class object from child class constructor, then:
			Vehicle v2 = new Car("Tesla", 4);
			// Overriden methods are stored in Parent class. So, parent can access it
			v2.Greet();					// Overriding calls child class method as expected
			// New methods after Method Hiding are stored in Child class. So, parent can't access it
			v2.ShowInfo();              // But, Method Hiding calls base class method
		}
	}
}