using System;

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
			return str == rev;                      // String Comaprison
		}
		public static void Main(string[] args)
		{
			Func<int, int, int> sum = add;
			Action<int, int> product = multiply;
			Predicate<string> isPalindrome = checkPalindrome;

			int result = sum(4, 5);
			Console.WriteLine("Sum: " + result);
			product(4, 5);
			Console.WriteLine(isPalindrome("noon"));

			Console.WriteLine("Lab No: 9c");
			Console.WriteLine("Name: Giver Khadka");
			Console.WriteLine("Roll No.: 05");
		}
	}
}
