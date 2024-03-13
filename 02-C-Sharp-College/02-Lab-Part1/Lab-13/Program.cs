using System;
using System.Collections.Generic;
using System.Linq;                  // Location of LINQ
namespace LINQApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<string> fruits = new List<string>()
			{
				"Mango Fruit",
				"Orange Juice",
				"Banana",
				"Apple Fruit",
				"Grape"
			};
			var result = from fruit in fruits where fruit.Contains("Fruit") select fruit;
			foreach (string res in result)
			{
				Console.WriteLine(res);
			}
		}
	}
}