using System;

namespace MultipleParameters
{
	public class Program
	{
		// 'params' allows to gather multiple parameters like REST Operator in JS
		static void Sum(params int[] nums)
		{
			int sum = 0;
			foreach(int x in nums)
			{
				sum += x;
			}	
			Console.WriteLine("Sum is: {0}", sum);
		}
		static void Main(string[] args)
		{
			// Passing varying number of parameters in same function
			Sum(1, 2, 3);
			Sum(1, 2, 3, 4, 5);
			Sum(1, 2, 3, 4, 5, 6, 7, 8, 9);

			// Normal array can also be passed in the function with 'params'
			int[] numbers = {1, 2, 3, 4, 5}; 
			Sum(numbers);
		}
	}
}