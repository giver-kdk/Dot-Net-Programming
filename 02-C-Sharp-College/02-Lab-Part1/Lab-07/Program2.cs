using System;

namespace InterfaceApp
{
	public interface IVehicle
	{
		public void ShowInfo();
		public void Greet();
	}
	public class Car : IVehicle
	{
		public void ShowInfo()
		{
			Console.WriteLine("This is a Car");
		}
		public void Greet()
		{
			Console.WriteLine("Hello car drive!");
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Car c1 = new Car();
			c1.ShowInfo();
			c1.Greet();
		}
	}
}
