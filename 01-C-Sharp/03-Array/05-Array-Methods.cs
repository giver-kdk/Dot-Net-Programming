using System;

namespace ArrayMethods
{
	public class Program
	{
		static void PrintArray(int[] arr)
		{
			foreach(int i in arr)
			{
				Console.Write("{0}\t", i);
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			int[] nums = {5, 4, 3, 2, 1};
			Console.Write("Original Array:\t");
			PrintArray(nums);
			// 'Array' is a class from 'System' namespace
			// 'Sort()' modifies the original array and it doesn't return anything
			Array.Sort(nums);
			Console.Write("Sorted Array:\t");
			PrintArray(nums);

			// Puts the array elements in reverse order. This also modifies original
			Array.Reverse(nums);
			Console.Write("Reversed Array:\t");
			PrintArray(nums);

			// Copy array using assignment operator
			int[] newNums = nums;
			Console.Write("Copied Array:\t");
			PrintArray(newNums);

			// Copy array to specific index of destination array
			int[] anotherNums = new int[15];
			// Syntax: src_array.CopyTo(dest_array, startIndex)
			nums.CopyTo(anotherNums, 3);
			Console.Write("Copied Array:\t");
			PrintArray(anotherNums);

			// Powerful way to copy array that allows: 
			// - Copy from desired index of source array
			// - Paste to desired index of destination array
			// - Copy desired length of source array to destination array
			int[] copiedArray = new int[15];
			// Syntax: Array.Copy(src, src_start, dest, dest_start, src_len) 
			// Read as "Source ko yo index dekhi destination ko yo index ma yeti length ko copy garney"
			Array.Copy(nums, 2, copiedArray, 5, 3);
			// Array.Copy(nums, 0, copiedArray, 0, nums.Length);		// Copies entire array normally
			Console.Write("Copied Array:\t");
			PrintArray(copiedArray);
		}
	}
}