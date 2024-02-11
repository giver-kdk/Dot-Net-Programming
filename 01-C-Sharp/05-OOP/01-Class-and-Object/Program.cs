using System;
// Import 'namespace' for using its class from another program file
// No need to import 'namespace' if anotehr program file has same namespace as this file.
// i.e; 'ShapeMath.cs' and 'Program.cs'
using AnimalNamespace;


namespace ClassObject
{
	public class Program
	{
		// Use 'struct' for simple data structures unlike class
		public struct Rectangle
		{
			 // double length = 5;			// Not allowed in 'struct'
			public double length;
			public double width;

			//public Rectangle(){}		// Default Constructor not allowed in 'struct'
			public Rectangle(double l, double w)
			{
				length = l;
				width = w;
			}

			public double GetArea()
			{
				return length * width;
			}
		}
		public static void Main(string[] args)
		{
			// 'Animal' class comes from 'AnimalNamespace' namespace
			Animal cow = new Animal();
			Console.WriteLine(cow.name);
			// 'static' method should be called with Class name
			Animal.PrintCount();

			// 'ShapeMath' class
			ShapeMath myShape = new ShapeMath(50, 30);
			double area1 = myShape.GetArea("rectangle");
			Console.WriteLine("Area of shape: {0}", area1);

			// 'Rectangle' struct. Not compulsary to use 'new' to create instance
			Rectangle r1;
			r1.length = 30;
			r1.width = 20;
			double area2 = r1.GetArea();
			Console.WriteLine("Rectangle struct area: {0}", area2);

			// Creating 'struct' instance using 'new' keyword
			Rectangle r2 = new Rectangle(60, 40);
			double area3 = r2.GetArea();
			Console.WriteLine("Rectangle struct area: {0}", area3);

			// NOTE: 
			// Struct doesn't allow initializing intance field(But allows static field)
			// Class allows initializing of both instance and static field
			// Struct can't have default contructor(without parameter)
			// Struct don't need 'new' operator for creating instance
			// Struct is value type
			// Class is reference type
			// Struct is lightweight and fast
			// Class is heavy and slow
			// Struct used for simple data structure
			// Class used for complex blueprint
			// Struct can easily be copied but no inheritance/polymorphism
			// Struct should not be large(otherwise slow), but class can be. 
		}
	}
}