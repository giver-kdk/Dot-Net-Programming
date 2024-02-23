using System;

// 'struct' is a type similar to 'class' but it is used for simple data structures
// Whereas 'class' is used to make complex data structures
// 'struct' can also have fields, methods and constructors like 'class'
// 'struct' is a value type, whereas 'class' is a reference type
// 'struct' can't be inheritated
// 'struct' can be placed both inside and outside of the class
namespace StructsApp
{
	public class Program
	{
		public struct Employee
		{
			//public string name; 
			public string name = "No Name";
			private string address;
			public int age;

			public static int empCount = 0;

			public Employee()
			{
				name = "No Name";
				address = "No Address";
				age = 0;
			}
			// Constructor for 'struct' same as for 'class'
			public Employee(string name, string address, int age)
			{
				this.name = name;
				this.address = address;
				this.age = age;
				empCount++;
			}
			public void ShowInfo()
			{
				Console.WriteLine("Employee Name: {0}", name);
				Console.WriteLine("Employee Age: {0}", age);
				Console.WriteLine("Employee Address: {0}", address);
			}

			public static void ShowCount()
			{
				Console.WriteLine("Number of Employee: {0}", empCount);
			}
		}
		public static void Main(string[] args)
		{
			// 'struct' instance created just like 'class' object creation
			Employee e1 = new Employee("Ram", "Kathmandu", 19);
			e1.ShowInfo();
			Employee.ShowCount();
			Console.WriteLine("Employee Number: {0}", Employee.empCount);
		}
	}
}