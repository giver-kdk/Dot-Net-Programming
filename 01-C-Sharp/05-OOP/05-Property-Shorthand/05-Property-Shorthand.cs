using System;

namespace Properties
{
	public class Circle
	{
		// No need of extra variable. Property creates it own variable internally
		//private double _Radius;
		// If no logic required and only direct retrieval and assignment needed, then we can use property as:
		// Here, we can assume 'Radius' as a variable itself
		public double Radius { get; set; }
		//public double Radius { get; set; } = 0		// Initialization
		public class Program
		{
			public static void Main(string[] args)
			{
				Circle c = new Circle();
				//Console.WriteLine(c.radius);		// Can't access private variable

				// 'set' accessor automatically runs during assignmnet
				c.Radius = 6.57;                    // Here, '6.57' is the 'value'
													// 'get' accessor automatically runs while accesing property
				Console.WriteLine("Circle radius is: {0}", c.Radius);
			}
		}
	}
}