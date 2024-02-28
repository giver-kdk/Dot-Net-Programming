using System;
using System.Collections.Generic;
// Generic Stack is same as Non-Generic Stack except it is type safe and accidental type mismatch is prevented

namespace GenericStackApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Stack<double> s1 = new Stack<double>();        // Generic Stack stores double data in LIFO order
			Stack<string> s2 = new Stack<string>();        // Generic Stack stores string data in LIFO order

			Stack<int> s = new Stack<int>();        // Generic Stack stores integer data in LIFO order
			s.Push(1);                              // Insert item in stack
			s.Push(2);
			s.Push(3);
			//s.Push("Hello");						// This will give syntac error, preventing type mismatch

			Console.WriteLine($"Stack lenght: {s.Count}");
			Console.WriteLine($"Stack has 1: {s.Contains(1)}");     // Check item in stack
																	// 'Pop()' returns last item and removes it from stack
			Console.WriteLine($"Popped item: {s.Pop()}");
			// 'Peek()' returns last item but doesn't remove it from stack
			Console.WriteLine($"Last item: {s.Peek()}");

			// Stack Traversal same as Array Traversal, but prints from last
			Console.WriteLine("Stack Traversal: ");
			foreach (int elem in s)
			{
				Console.WriteLine(elem);
			}

			// Generic Stack to Array Conversion 
			int[] nums = s.ToArray();
			Console.WriteLine("Array Traversal: ");
			foreach (int elem in nums)
			{
				Console.WriteLine(elem);
			}

			s.Clear();
			Console.WriteLine("After Stack Clearing: ");
			foreach (int elem in s)
			{
				Console.WriteLine(elem);
			}
		}
	}
}