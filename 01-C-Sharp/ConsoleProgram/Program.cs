using System;
// Delegate pointing to multiple methods is called multilcast delegate
// It is needed when we multiple methods have same signature and parameters

namespace DelegateApp
{
	public class Program
	{
		// Delegate declaration with a signature
		public delegate void MyDelegate(double p1, double p2);
		public delegate double MyValueDelegate(double p1, double p2);
		// Method not returning anything
		public void PrintArea(double l, double b)
		{
			Console.WriteLine(l * b);
		}
		public void PrintPerimeter(double l, double b)
		{
			Console.WriteLine(2 * (l + b));
		}

		// Methods returning some value
		public double GetArea(double l, double b)
		{
			return (l * b);
		}
		public double GetPerimeter(double l, double b)
		{
			return (2 * (l + b));
		}
		public static void Main(string[] args)
		{
			// First, create an class's object to reference the method 
			Program p1 = new Program();

			MyDelegate md1 = p1.PrintArea;
			MyDelegate md2 = p1.PrintPerimeter;
			MyDelegate? md3 = md1 + md2;              // Set multiple target methods. Order matters for execution.

			md3(5, 2);                                // Calls both methods
			md3 = md3 - md1;						  // Detaches the pointer to function which is being subtracted
			md3(6, 3);                                // Calls only one method
			Console.WriteLine();

			// PROBLEM: We can't simply get the returned value of multiple methods pointed by delegate
			MyValueDelegate md4 = p1.GetArea;
			MyValueDelegate md5 = p1.GetPerimeter;
			MyValueDelegate md6 = md4 + md5;              // Set multiple target methods that return some value
			double result = md6(5, 2);                                  // Here, response of last method overrides 'result' value
			Console.WriteLine("Result is: {0}", result);
			Console.WriteLine();

			// SOLUTION: We can get the returnd value of multiple methods pointed by delegate by extracting it during invocations
			Delegate[] delegates = md6.GetInvocationList();				// Get list of all delegated referencing to multiple methods 
			foreach (Delegate deleg in delegates)						// Loop to access individual delegate
			{	
				double res = (double) deleg.DynamicInvoke(5, 2);		// Execute each delegate with 'DynamicInvoke()'
				Console.WriteLine(res);									
			}
		}
	}
}