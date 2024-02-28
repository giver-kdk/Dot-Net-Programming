using System;
using System.Collections.Generic;
// Generic Queue is same as Non-Generic Queue except it is type safe and accidental type mismatch is prevented

namespace QueueApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Queue<double> q1 = new Queue<double>();          // Generic 'Queue' stores double data in FIFO order
			Queue<string> q2 = new Queue<string>();          // Generic 'Queue' stores string data in FIFO order

			Queue<int> q = new Queue<int>();          // Generic 'Queue' stores integer data in FIFO order
													  // Insert items into the Queue
			q.Enqueue(1);
			q.Enqueue(2);
			q.Enqueue(3);
			//q.Enqueue("Hello");			// This is give syntax error, preventing from type mismatch

			Console.WriteLine($"Generic Queue has 1: {q.Contains(2)}"); // Checks if queue has specified item
			Console.WriteLine($"Generic Queue length: {q.Count}");          // Returns queue length
																			// 'Dequeue' returns first item and removes it from queue
			Console.WriteLine($"Dequeued Item: {q.Dequeue()}");

			// 'Peek' returns first item but doesn't remove it from generic queue
			Console.WriteLine($"First Item: {q.Peek()}");

			// Generic Queue traversal is similar to Array Traversal
			Console.WriteLine("Generic Queue Traversal:");
			foreach (object obj in q)
			{
				Console.WriteLine(obj);
			}

			// Converting Generic Queue to Array
			int[] nums = q.ToArray();

			Console.WriteLine("Array Traversal:");
			foreach (int elem in nums)
			{
				Console.WriteLine(elem);
			}

			// Clearing all items of Generic Queue
			q.Clear();
			Console.WriteLine("After Generic Queue Clearing:");
			foreach (int elem in q)
			{
				Console.WriteLine(elem);
			}
		}
	}
}