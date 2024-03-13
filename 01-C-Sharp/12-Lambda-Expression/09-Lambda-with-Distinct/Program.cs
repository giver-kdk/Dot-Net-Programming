using System;
using System.Collections.Generic;

namespace LambdaDistinct
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> nums1 = new List<int>() { 1, 2, 3, 1, 2, 3 };
			// 'Disctinct()' eliminates duplicate values and returns unique values
			List<int> res = nums1.Distinct().ToList();
			Console.WriteLine("Distinct Values are: ");
			foreach (int i in res)
			{
				Console.WriteLine(i);
			}
		}
	}
}
