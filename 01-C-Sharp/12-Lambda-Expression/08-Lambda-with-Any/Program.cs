using System;
using System.Collections.Generic;

namespace LambdaAny
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> nums1 = new List<int>() { 1, 2, 3, 4, 5 };
			// 'Any' checks if certain condition is satisfied by atleast one element or not
			bool res = nums1.Any(x => x > 4);                   // 'Any()' returns boolean value

			Console.WriteLine("At least one item is greater than 4: " + res);
		}
	}
}
