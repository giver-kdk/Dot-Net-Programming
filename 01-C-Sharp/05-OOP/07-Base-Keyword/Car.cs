using System;

namespace BaseKeyword
{
	public class Car : Vehicle
	{
		public int Wheels { get; set; }

		public Car() { }
		// Accessing parent constructor. 'base()' runs before child constructor
		public Car(string n, double s, int w) : base(n, s)
		{
			Wheels = w;
		}
		public void ShowInfo()
		{
			// Accessing parent method
			base.ShowName();
			// Accessing parent field
			Console.WriteLine("Vehicle Speed: {0}", base.Speed);
			Console.WriteLine("Wheels Number: {0}", Wheels);
		}
	}
}
