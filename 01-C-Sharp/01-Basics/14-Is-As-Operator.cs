using System;
// 'is' operator is used to check if two types are same or not. Returns True if same, else False
// 'as' operator is used to convert compatible data types(reference or nullable types).
// 'as' operator returns converted type if compatible, else 'null'

namespace IsAsOperator
{
	public class Program
	{
		public static void Main(string[] args)
		{
			object a = 5;
			object b = "Giver";
			if (a is int) Console.WriteLine("Same Type");
			else Console.WriteLine("Different Type");

			if (b is string) Console.WriteLine("Same Type");
			else Console.WriteLine("Different Type");

			if (a is string) Console.WriteLine("Same Type");
			else Console.WriteLine("Different Type");

			object c = "Hello";
			string num = c as string;               // Converting 'object' to 'string'
			Console.WriteLine(c);

		}
	}
}