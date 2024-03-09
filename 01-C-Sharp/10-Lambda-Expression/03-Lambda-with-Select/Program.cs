using System;
using System.Collections.Generic;

namespace LambdaSelect
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
			// Lambda Expression inside 'Select()' method used for operation in each item
			// 'Select()' is similar to 'map()' method in JS
			List<int> res = nums.Select(x => x * 2).ToList();
			foreach (int i in res)
			{
				Console.WriteLine(i);
			}
		}
	}
}
