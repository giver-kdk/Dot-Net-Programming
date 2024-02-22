using System;

 namespace InterfaceApp
{
	// It is a convention to start 'Interface' name with 'I'
	public interface IVehicle
	{
		// It only contains declaration of method/properties (It doesn't have fields cause field is implementation)
		public string Name { get; set; }
		//private string Model { get; set; }	// Interface members should always be 'public'

		//public IVehicle() { }					// Interface can't have contructor because it doesn't have variables for setting

		// In interface, methods are 'abstract' by defauilt. So, no need to specify as 'abstract'
		public void ShowInfo();
		public void Greet();
	}

	// Implementing Interface by inheritance
	public class Car : IVehicle
	{
		// Must write this again to implement the 'Property' declared in Interface
		// In real scenario, we can write logic in 'get'/'set' accessors
		public string Name { get; set; }

		public void ShowInfo()
		{
			Console.WriteLine("Car name is {0}", Name);
		}
		public void Greet()
		{
			Console.WriteLine("Hello car drive!");
		}
	}
}
