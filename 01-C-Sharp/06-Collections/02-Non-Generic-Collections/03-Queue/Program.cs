using System;
using System.Collections;

namespace QueueApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Queue q = new Queue();          // 'Queue' stores data in FIFO order
											// Insert items into the Queue
			q.Enqueue(1);
			q.Enqueue(2);
			q.Enqueue(3);

			Console.WriteLine($"Queue has 1: {q.Contains(2)}"); // Checks if queue has specified item
			Console.WriteLine($"Queue length: {q.Count}");          // Returns queue length
																	// 'Dequeue' returns first item and removes it from queue
			Console.WriteLine($"Dequeued Item: {q.Dequeue()}");

			// 'Peek' returns first item but doesn't remove it from queue
			Console.WriteLine($"First Item: {q.Peek()}");

			// Queue traversal is similar to Array Traversal
			Console.WriteLine("Queue Traversal:");
			foreach (object obj in q)
			{
				Console.WriteLine(obj);
			}

			// Converting Queue to Array
			object?[] nums = q.ToArray();

			Console.WriteLine("Array Traversal:");
			foreach (object obj in nums)
			{
				Console.WriteLine(obj);
			}

			// Clearing all items of Queue
			q.Clear();
			Console.WriteLine("After Queue Clearing:");
			foreach (object obj in q)
			{
				Console.WriteLine(obj);
			}
		}
	}
}