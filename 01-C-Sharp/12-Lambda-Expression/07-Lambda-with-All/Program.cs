using System;
using System.Collections.Generic;

namespace LambdaAll
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> nums1 = new List<int>() { 1, 2, 3, 4, 5 };
			// 'All' checks if certain condition is strictly satisfied by all elements or not
			bool res = nums1.All(x => x > 0);                   // 'All()' returns boolean value

			Console.WriteLine("All items are positive: " + res);
		}
	}
}
