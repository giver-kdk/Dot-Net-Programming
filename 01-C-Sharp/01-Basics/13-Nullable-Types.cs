using System;

namespace NullableTypes
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// By default, variables are not nullable
			// int a = null;			// Not Allowed

			// Use '?' symbol to explicitely make variables nullable
			int? a = null;
			if (a == null) Console.WriteLine("Variable is Nullable");
			else Console.WriteLine("Variable is not Nullable");

			if (!a.HasValue) Console.WriteLine("Variable is Nullable");
			else Console.WriteLine("Variable is not Nullable");

			// String has it's own method to check null value
			string? name = null;
			if (String.IsNullOrEmpty(name)) Console.WriteLine("String is Nullable");
			else Console.WriteLine("String is not Nullable");
		}
	}
}