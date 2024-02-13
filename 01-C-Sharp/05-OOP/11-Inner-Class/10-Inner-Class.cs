using System;

// Inner class(Nested Type) is class inside another class. It is an 'Encapsulation' technique
// It is needed to make sure, inner class is accessed only via Outer class (But not inheritated)
// This approach helps to write clean and maintainable code
namespace InnerClass
{
	public class OuterClass
	{
		public int num1;
		public static int setOuterCount = 0;
		// We can directly create object from inner class in outer class. 
		// NOTE: We get infinite loop if both inner class and outer class refer to each other to create object. So, this is commented
		//InnerClass innerObj = new InnerClass();

		// Cannot directly access the inner class members
		//innerObj.num2 = 3;

		public int GetsetOuterCount()
		{
			return setOuterCount;
		}
		public class InnerClass
		{
			public int num2;
			// We can directly create object from outer class in inner class
			OuterClass outerObj = new OuterClass();
			public InnerClass()
			{
				this.num2 = 0;
			}
			public InnerClass(int num)
			{
				this.num2 = num;
			}
			// Cannot directly access the outer class members
			//outerObj.num1 = 2

			public void SetOuter(int n)
			{
				// Access outer class members via methods
				outerObj.num1 = n;
				// Accessing static member of outer class from inner class 
				setOuterCount++;
			}
			public int GetOuter()
			{
				// Access outer class members via methods in 'Main()'.
				return outerObj.num1;
			}
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			// We cannot directly access the inner class in 'Main()'
			//InnerClass i1 = new InnerClass();

			// Accessing inner class via outer class	
			OuterClass.InnerClass i1 = new OuterClass.InnerClass(5);
			i1.SetOuter(10);
			Console.WriteLine("Inner Number: {0}", i1.num2);
			// Can't access	outer object inside inner object directly from 'Main()' as well
			// Console.WriteLine(i1.outerObj.num1);
			Console.WriteLine("Outer Number inside Inner Number: {0}", i1.GetOuter());

			// Static member modified by inner class 
			Console.WriteLine("Number of outer Objects: {0}", OuterClass.setOuterCount);
		}
	}
}