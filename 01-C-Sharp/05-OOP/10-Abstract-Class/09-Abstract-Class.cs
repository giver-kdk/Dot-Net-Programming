// Abstract Methods are simply dynamic 'Polymorphism' 
using System;

namespace AbstractClass
{
	// If a class is 'abstract' then it means, it is incomplete and 
	// Some features needs to be implemented by child classes to be complete
	public abstract class Vehicle			// Class should be abstract if atleast one method is abstract
	{
		public string Name { get; set; }
		public double Speed { get; set; }

		public Vehicle(string n, double s)
		{
			Name = n;
			Speed = s;
		}
		// Abstract methods should only be declared(not defined). It must be implemented by child class
		// It is only allowed inside 'abstract' class.
		// It is just a indication that child classs should define this method by overriding
		public abstract void ShowInfo();
	}
	public class Car : Vehicle
	{
		public int Wheels { get; set; }
		public Car(string n, double s, int w) : base(n, s)
		{
			Wheels = w;
		}
		// Overwriding abstract method of parent class
		public override void ShowInfo()
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
			// 'abstract' class cannot be instanciated due to abscence of method implementation. 
			// It is only supposed to be a base class
			//Vehicle v1 = new Vehicle("Buggatti", 380);

			Car c1 = new Car("Lamborgini", 400, 4);
			c1.ShowInfo();
		}
	}
}