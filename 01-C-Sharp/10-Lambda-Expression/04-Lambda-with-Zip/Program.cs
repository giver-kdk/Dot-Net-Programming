using System;
using System.Collections.Generic;

namespace LambdaZip
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> nums1 = new List<int>() { 1, 2, 3, 4, 5 };
			List<int> nums2 = new List<int>() { 6, 7, 8 };          // 'Zip()' iterates until the smallest list length
			// Lambda Expression inside 'Zip()' method used to combine two lists with operations on corresponding items
			// Imagine 'Zip()' like closing a bag zip chain and connecting each strips
			// Here, '(x, y)' are the respective elements of 'nums1' and 'nums2' list
			List<int> res = nums1.Zip(nums2, (x, y) => x + y).ToList();
			foreach (int i in res)
			{
				Console.WriteLine(i);
			}
		}
	}
}
