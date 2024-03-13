using System;
using System.Collections.Generic;

namespace LambdaIntersect
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> nums1 = new List<int>() { 1, 2, 3, 4, 5 };
			List<int> nums2 = new List<int>() { 3, 4, 5, 6, 7 };
			// 'Intersect()' returns common values between two lists
			List<int> res = nums1.Intersect(nums2).ToList();
			Console.WriteLine("Intersecting Values are: ");
			foreach (int i in res)
			{
				Console.WriteLine(i);
			}
		}
	}
}
