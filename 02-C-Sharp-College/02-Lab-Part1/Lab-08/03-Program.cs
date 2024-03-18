using System;

namespace StructEnumPartialClass
{
	public partial class Program				// Partial Class
	{
		public static void Main(string[] args)
		{
			// Implementing Struct
			Employee emp1 = new Employee("Ram", "Kathmandu");
			emp1.ShowInfo();

			// Implementing Enum
			CarColor carC1 = CarColor.Red;
			Console.WriteLine(carC1);
			Console.WriteLine((int)carC1);
			Console.WriteLine("Lab No: 8");
			Console.WriteLine("Name: Giver Khadka");
			Console.WriteLine("Roll No.: 05");
		}
	}
}