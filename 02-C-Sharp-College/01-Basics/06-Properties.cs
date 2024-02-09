using System;

namespace Properties
{
	public class Circle
	{
		// We can't access private variable directly
		// It's a good practice to use '_variable_name' for corresponding property 
		public double _Radius;
		// Using 'Getter' and 'Setter' method is not handy
		// 'Property' helps to use these functionality but also allows us to use it like a variable
		public double Radius
		{
			// 'get' property accessor
			get
			{
				return _Radius;
			}
			// 'set' property accessor. We can add custom logic before value assignment
			set
			{
				// 'value' is the value assigned by coder using '=' operator
				if (value > 0) _Radius = value;
				else _Radius = 0;
			}
		}
		public class Program
		{
			public static void Main(string[] args)
			{
				Circle c = new Circle();
				//Console.WriteLine(c.radius);		// Can't access private variable

				// 'set' accessor automatically runs during assignmnet
				c.Radius = 6.57;                    // Here, '6.57' is the 'value'
													// 'get' accessor automatically runs while accesing property
				Console.WriteLine("Circle radius property is: {0}", c.Radius);
				Console.WriteLine("Circle radius variable is: {0}", c._Radius);
			}
		}
	}
}