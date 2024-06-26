using System;

// C# provides built-in delegates: Func, Action and Predicate
// We don't have to create custom delegate everytime if we use these

namespace FuncDelegate
{
	public class Program
	{
		public static int add(int a, int b)
		{ return a + b; }
		public static void multiply(int a, int b)
		{ Console.WriteLine("Product: " + a * b); }
		public static bool checkPalindrome(string str)
		{
			char[] chars = str.ToCharArray();       // String to Array
			Array.Reverse(chars);                   // Reverse the Array
			string rev = new string(chars);         // Array to String
			return str == rev;                      // String Comparison
		}
		public static void Main(string[] args)
		{
			// Func Delegate is used to create delegate that returns something
			Func<int, int, int> sum = add;
			// Action Delegate is used to create delegate that doesn't return anything
			Action<int, int> product = multiply;
			// Predicate Delegate is used to create delegate that takes one parameter and returns boolean
			Predicate<string> isPalindrome = checkPalindrome;

			int result = sum(4, 5);
			Console.WriteLine("Sum: " + result);
			product(4, 5);
			Console.WriteLine(isPalindrome("noon"));
		}
	}
}
