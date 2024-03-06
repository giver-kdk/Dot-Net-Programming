using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace EnumeratedType
{
	public class Program
	{
		// This enum should be made public to be accessible to methods
		public enum CarColor
		{
			// Code goes like 0, 1, 2...
			Red,
			Blue,
			Green
		}
		// Sepcifying enum member types manually. Default is 'int'
		public enum CarType : byte
		{
			// Code goes like 10, 11, 12...
			Classic = 10,
			Sports,
			Vintage
		}
		public static void PaintCar(CarColor c1)
		{
			Console.WriteLine("Car color is: {0}", c1);
			Console.WriteLine("Color code is: {0}", (int)c1);
		}
		public static void SeeCar(CarType t1)
		{
			Console.WriteLine("Car type is: {0}", t1);
			Console.WriteLine("Type code is: {0}", (int)t1);
		}
		public static void Main(string[] args)
		{
			CarColor carC1 = CarColor.Red;
			PaintCar(carC1);

			CarType carT1 = CarType.Vintage;
			SeeCar(carT1);
		}
	}
}