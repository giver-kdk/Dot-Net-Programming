using System;
using System.Collections.Generic;

namespace LambdaUnion
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> nums1 = new List<int>() { 1, 2, 3, 4, 5 };
			List<int> nums2 = new List<int>() { 3, 4, 5, 6, 7 };
			// 'Union()' perform union operation between two lists
			List<int> res = nums1.Union(nums2).ToList();
			Console.WriteLine("Union Values are: ");
			foreach (int i in res)
			{
				Console.WriteLine(i);
			}
		}
	}
}
