using System;
using System.Collections.Generic;

namespace LambdaAggregate
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> nums1 = new List<int>() { 1, 2, 3, 4, 5 };
			// 'Aggregate()' method is similar to 'reduce()' method in JS
			// It accumulates result based upon operation between 'x' and 'y'
			// Here, 'x' is accumulator and 'y' is next element
			int res = nums1.Aggregate((x, y) => x + y);
			//int res = nums1.Aggregate(2, (x, y) => x + y);			// Providing value to accumulator. Default accumulator = 1st element
			Console.WriteLine("Sum of list items: " + res);
		}
	}
}
