using System;

namespace InterfaceApp
{
	public interface IVehicle               // Interface 1
	{
		public void ShowInfo();
		public void Greet();
	}
	public interface IEngine                // Interface 2
	{
		public void Start();
		public void Stop();
	}
	public class Car : IVehicle, IEngine    // Multiple Inheritance
	{
		public void ShowInfo()
		{
			Console.WriteLine("This is a Car");
		}
		public void Greet()
		{
			Console.WriteLine("Hello car drive!");
		}
		public void Start()
		{
			Console.WriteLine("Car engine started!");
		}
		public void Stop()
		{
			Console.WriteLine("Car engine stopped!");
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Car c1 = new Car();
			c1.ShowInfo();
			c1.Greet();
			c1.Start();
			c1.Stop();
		}
	}
}
