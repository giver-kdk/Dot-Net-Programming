using System;

namespace GetterSetter
{
	public class Circle
	{
		// We can't access private variable directly
		private double radius;
		// We use 'Getter' and 'Setter' method to access and assign values
		public double GetRadius()
		{
			return radius;
		}
		public void SetRadius(double r)
		{
			// We can also perform additional logic if needed 
			radius = r;
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Circle c = new Circle();
			//Console.WriteLine(c.radius);		// Can't access private variable

			c.SetRadius(6.57);
			Console.WriteLine("Circle radius is: {0}", c.GetRadius());
		}
	}
}