/*
	- We know 'reference types' makes the original variable modified anyhow. 
	- To modify original variable of 'value type', use 'ref' or 'out' keyword
*/
using System;

namespace PassRef
{
	public class Program
	{
		// Method taking reference of variable as parameter
		static void Modify(ref int i)
		{
			i *= 2;
			Console.WriteLine("Modified i = {0}", i);
		}
		static void Main(string[] args)
		{
			int i = 10;
			Console.WriteLine("Before Modification,  i = {0}", i);
			// Passing reference of variable as argument
			Modify(ref i);
			Console.WriteLine("After Modification,  i = {0}", i);
		}
	}
}
