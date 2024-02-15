using System;
// 'Interface' is a COMPLETE abstract class. It is like a contract that needs to be satisfied during inheritance.
// To use 'Interface', class/struct should inherit the 'Interface'
// All the 'Interface' methods/properties should compulsorily be implemented in child class/struct

// NOTE: If multiple classes use same Interface, then all of them will have a common standard to communication with each other
// So, basically, there becomes an Interface for all the classes to communicate

namespace InterfaceApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//IVehicle v1 = new IVehicle();				// Cannot instantiate from Interface

			// 'Car' class is inheritated from 'IVehicle' interface
			Car c1 = new Car();
			c1.Name = "Lamorgini";
			c1.ShowInfo();
			c1.Greet();
		}
	}
}