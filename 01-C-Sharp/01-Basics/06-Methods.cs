// Methods are declared inside classes
// Methods can either be: 'instance' (Default) or 'static'
// To invoke 'instance' methods, we need to create object from the class containing the method
// To invoke 'static' methods, we don't have to create object. We can directly use Class name

// Method Syntax: 
/*
	<access_modifier> [<static>] <return_type> <method_name>([<parameters>])
	{
		// Statement
	}

	For example: 
	public static void MyFunction(string name)
	{
		Console.WriteLine(name);
	}
*/
using System;

namespace Methods
{
	public class Car
	{
		// Here, 'public' allows use to call the function by other classes as well
		public static void GreetCustomer()						// Static Method
		{
			Console.WriteLine("Greeting Customer!!!");
		}
	}
	public class Program
	{
		// Static Method
		static void Square(int i)
		{
			Console.WriteLine(i * i);
		}
		// Instance Method
		void GreetUser()
		{
			Console.WriteLine("Hello User!!!");
		}
		static void Main(string[] args)
		{
			// Invoking 'static' method directly
			Square(4);
			// Invoking 'instance' method via object
			Program obj1 = new Program();		// Create object dynamically
			obj1.GreetUser();
			// GreetUser();						// This is not allowed

			// Need to mention Class name if method belongs to other class
			Car.GreetCustomer();
		}
	}
}