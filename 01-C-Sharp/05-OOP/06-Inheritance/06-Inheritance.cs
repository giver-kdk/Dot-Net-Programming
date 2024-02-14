using System;

// In Inheritance: Child Class will have 'IsA' relation with Parent Class
namespace Inheritance
{
	public class Vehicle
	{
		// Properties
		public string? Name { get; set; } = null;
		public double Price { get; set; } = 0;
		public double Speed { get; set; } = 0;
		// Default Constructor
		public Vehicle(string n, double p, double s)
		{
			Name = n;
			Price = p;
			Speed = s;
		}

		public void Start()
		{
			Console.WriteLine("Vehicle is running at speed: {0}", Speed);
		}
	}
	// 'Vehicle' becomes base class for 'Car'
	public class Car : Vehicle
	{
		public int NumOfWheels { get; set; } = 0;
		// Utilizing Base Class Constructor with 'base' keyword
		// 'base()' calls the base class constructor with given parameter
		public Car(string n, double p, double s) : base(n, p, s)
		{
			// Setting default number of wheels when not provided by user
			NumOfWheels = 4;
		}
		public Car(string n, double p, double s, int w) : base(n, p, s)
		{
			NumOfWheels = w;
		}

		public void StartCar()
		{
			Console.WriteLine("Car is running at speed: {0} with {1} wheel", Speed, NumOfWheels);
		}
	}

	// 'Car' becomes base class for 'ElectricCar'. 'ElectricCar' has nothing to do with 'Vehicle' directly
	public class ElectricCar : Car
	{
		public double BatteryLevel { get; set; } = 0;

		public ElectricCar(string n, double p, double s, int w, double b) : base(n, p, s, w)
		{
			BatteryLevel = b;
		}
		public void StartCharging()
		{
			BatteryLevel++;
			Console.WriteLine("Car is charging. Battery Level: {0}", BatteryLevel);
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Vehicle v1 = new Vehicle("Buggatti", 20000, 400);
			Console.WriteLine("Vehicle Name: {0}", v1.Name);
			Console.WriteLine("Vehicle Price: {0}", v1.Price);
			Console.WriteLine("Vehicle Speed: {0}", v1.Speed);

			Car c1 = new Car("Lamborgini", 25000, 380);
			Console.WriteLine("Car Name: {0}", c1.Name);
			Console.WriteLine("Car Price: {0}", c1.Price);
			Console.WriteLine("Car Speed: {0}", c1.Speed);
			Console.WriteLine("Car Wheels: {0}", c1.NumOfWheels);

			Car c2 = new Car("Covini", 22000, 390, 6);
			Console.WriteLine("Car Name: {0}", c2.Name);
			Console.WriteLine("Car Price: {0}", c2.Price);
			Console.WriteLine("Car Speed: {0}", c2.Speed);
			Console.WriteLine("Car Wheels: {0}", c2.NumOfWheels);

			ElectricCar e1 = new ElectricCar("Tesla", 22000, 390, 4, 70);
			Console.WriteLine("Electric Car Name: {0}", e1.Name);
			Console.WriteLine("Electric Car Price: {0}", e1.Price);
			Console.WriteLine("Electric Car Speed: {0}", e1.Speed);
			Console.WriteLine("Electric Car Wheels: {0}", e1.NumOfWheels);
			Console.WriteLine("Electric Car Battery: {0}", e1.BatteryLevel);
			e1.StartCharging();
		}
	}
}