using System;

namespace BaseKeyword
{
	public class Vehicle
	{
		public string Name { get; set; } = "No Name";
		public double Speed { get; set; } = 0;

		public Vehicle() { }
		public Vehicle(string n, double s)
		{
			Name = n; Speed = s;
		}
		public void ShowName()
		{
			Console.WriteLine("Vehicle Name: {0}", Name);
		}
	}
}
