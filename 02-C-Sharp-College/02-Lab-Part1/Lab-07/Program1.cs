using System;

namespace AbstractClass
{
	public abstract class Vehicle                   // Abstract Class       
	{
		public string Name { get; set; }
		public double Speed { get; set; }
		public Vehicle(string n, double s)
		{
			Name = n;
			Speed = s;
		}
		public abstract void ShowInfo();
	}
	public class Car : Vehicle
	{
		public int Wheels { get; set; }
		public Car(string n, double s, int w) : base(n, s)
		{
			Wheels = w;
		}
		public override void ShowInfo()     // Overwriding abstract method
		{
			Console.WriteLine("Car Name: {0}", Name);
			Console.WriteLine("Car Speed: {0}", Speed);
			Console.WriteLine("Number of Wheels: {0}", Wheels);
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Car c1 = new Car("Lamborgini", 400, 4);
			c1.ShowInfo();
			Console.WriteLine("Lab No: 7a");
			Console.WriteLine("Name: Giver Khadka");
			Console.WriteLine("Roll No.: 05");
		}
	}
}