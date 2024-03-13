using System;
using System.Collections.Generic;

namespace LambdaExcept
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> nums1 = new List<int>() { 1, 2, 3, 4, 5 };
			List<int> nums2 = new List<int>() { 3, 4, 5, 6, 7 };
			// 'Except()' performs 'A - B' set operation where values of set A not present in set B is returned
			List<int> res1 = nums1.Except(nums2).ToList();
			List<int> res2 = nums2.Except(nums1).ToList();
			Console.WriteLine("Unique Values in List 1: ");
			foreach (int i in res1)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Unique Values in List 2: ");
			foreach (int i in res2)
			{
				Console.WriteLine(i);
			}
		}
	}
}
