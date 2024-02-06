using System;

namespace ShapeNamespace
{
	public class ShapeMath
	{
		public double length1;
		public double length2;
		// Constructor function 
		public ShapeMath(int l1, int l2)
		{
			this.length1 = l1;
			this.length2 = l2;
		}
		public double GetArea(string shape)
		{
			if(String.Compare(shape, "Rectangle", true) == 0)
			{
				return length1 * length2;
			}
			else if(String.Compare(shape, "Circle", true) == 0)
			{
				return Math.PI * Math.Pow(length1, 2);
			}
			else if(String.Compare(shape, "Triangle", true) == 0)
			{
				return (length1 / 2) * length2;
			}
			else
			{
				return -1;
			}
		}
	}
}
