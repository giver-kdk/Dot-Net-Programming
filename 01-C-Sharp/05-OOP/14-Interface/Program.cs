using System;
// 'Interface' is a COMPLETE abstract class. It is like a contract that needs to be satisfied during inheritance.
// To use 'Interface', class/struct should inherit the 'Interface'
// All the 'Interface' methods/properties should compulsorily be implemented in child class/struct

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