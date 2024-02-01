using System;

namespace ArraySearch
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] nums = {1, 2, 3, 4, 5};

			// Search for a key. Just like searching algorithm
			int key = 3;
			Console.WriteLine(Array.IndexOf(nums, key));

			// Find first array element that satisfies the condition
			// The 'x => x > 3' is called Predicate. Syntax is similar to JS arrow function
			Console.WriteLine(Array.Find(nums, (x) => x > 2));
			Console.WriteLine(Array.Find(nums, x => x > 3));

			// Returns filtered array elements that satisfies the condition
			// Here, we filter all elements greater than 2
			int[] filtered = Array.FindAll(nums, x => x > 2);
			// Using 'foreach' because we don't know array length
			foreach (var item in filtered)
			{
				Console.Write("{0}\t", item);
			}
			Console.WriteLine();
		}
	}
}