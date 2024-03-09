using System;

namespace DelegateApp
{
	// Delegate can be declared inside or outside the class
	public delegate void MyDelegate();
	public class Program
	{
		public static void Method1()
		{
			Console.WriteLine("Method 1");
		}
		public static void Method2()
		{
			Console.WriteLine("Method 2");
		}
		public static void Main(string[] args)
		{
			MyDelegate md1 = Method1;
			MyDelegate md2 = Method2;

			md1();          // Invokes 'Method1()'
			md2();          // Invokes 'Method2()'

			MyDelegate md3 = md1 + md2;     // Multicast Delegate
			md3();          // Invokes both 'Method1()' and 'Method2()'

			md3 -= md1;
			md3();			// Invokes 'Method2()'
		}
	}
}