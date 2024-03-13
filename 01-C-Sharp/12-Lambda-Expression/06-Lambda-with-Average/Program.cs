using System;
using System.Collections.Generic;

namespace LambdaAverage
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> nums1 = new List<int>() { 1, 2, 3, 4, 5 };
			// 'Average()' returns average value from the list elements
			int res = (int)nums1.Average();

			Console.WriteLine("Average of list items: " + res);
		}
	}
}
