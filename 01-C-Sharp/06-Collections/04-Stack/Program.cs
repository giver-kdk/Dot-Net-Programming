using System;
using System.Collections;

namespace StackApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Stack s = new Stack();                  // Stack stores data in LIFO order
			s.Push(1);                              // Insert item in stack
			s.Push(2);
			s.Push(3);

			Console.WriteLine($"Stack lenght: {s.Count}");
			Console.WriteLine($"Stack has 1: {s.Contains(1)}");     // Check item in stack
																	// 'Pop()' returns last item and removes it from stack
			Console.WriteLine($"Popped item: {s.Pop()}");
			// 'Peek()' returns last item but doesn't remove it from stack
			Console.WriteLine($"Last item: {s.Peek()}");

			// Stack Traversal same as Array Traversal, but prints from last
			Console.WriteLine("Stack Traversal: ");
			foreach (object obj in s)
			{
				Console.WriteLine(obj);
			}

			// Stack to Array Conversion 
			object?[] nums = s.ToArray();
			Console.WriteLine("Array Traversal: ");
			foreach (object obj in nums)
			{
				Console.WriteLine(obj);
			}

			s.Clear();
			Console.WriteLine("After Stack Clearing: ");
			foreach (object obj in s)
			{
				Console.WriteLine(obj);
			}
		}
	}
}