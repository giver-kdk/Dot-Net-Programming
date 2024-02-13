using System;

namespace MethodHiding
{
	public class Vehicle
	{
		public string Name { get; set; }

		public Vehicle() { }
		public Vehicle(string n)
		{
			Name = n;
		}
		// Method to be Overridden
		public virtual void Greet()
		{
			Console.WriteLine("Hello Vehicle Driver!");
		}
		// Method to be Hidden
		public void ShowInfo()
		{
			Console.WriteLine("Vehicle Name is: {0}", Name);
		}
	}
}