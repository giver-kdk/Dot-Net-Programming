/*
	- We know 'reference types' makes the original variable modified anyhow. 
	- To modify original variable of 'value type', use 'ref' or 'out' keyword
*/
using System;

namespace PassRef
{
	public class Program
	{
		// Using 'ref'
		static void Modify(ref int i)
		{
			i *= 2;
			Console.WriteLine("Modified i = {0}", i);
		}
		// 'out' used when method returns multiple values and 
		// Variable can declared on time of calling the method
		public static string Increment(out int num)
		{
			num = 1;		// Needs to be initialized inside method
			num++;
			return String.Format("Increment is {0}", num);
		} 
		// Using 'ref readonly'
		// Using 'in'
		static void Main(string[] args)
		{
			int i = 10;
			Console.WriteLine("Before Modification,  i = {0}", i);
			// Passing reference of variable as argument
			Modify(ref i);
			Console.WriteLine("After Modification,  i = {0}", i);
			// int n;			// No need to initialize for using 'out'
			string result = Increment(out int n);
			Console.WriteLine(result);
		}
	}
}
