using System;
using System.Collections.Generic;

namespace LinkedListProgram
{
	public class Program
	{
		public static void Display(LinkedList<int> list)
		{
			foreach (int elem in list)
			{
				Console.Write(elem + "\t");
			}
			Console.WriteLine();
		}
		public static void Main(string[] args)
		{
			LinkedList<int> l1 = new LinkedList<int>();
			l1.AddLast(1);
			l1.AddLast(2);
			l1.AddLast(3);

			Console.WriteLine("Adding from Last: ");
			Display(l1);

			l1.AddFirst(4);
			l1.AddFirst(5);
			l1.AddFirst(6);
			Console.WriteLine("Adding from First: ");
			Display(l1);

			// To insert element in the middle, we need a node pointer. 'LinkListNode' is a node pointer.
			// 'Find()' returns the first node with specified value
			LinkedListNode<int> current = l1.Find(6);
			Console.WriteLine("Value of Node 6: " + current.Value);
			Console.WriteLine("Value of Next Node: " + current.Next.Value);
			// 'Previous' returns null if current node is the first node
			//Console.WriteLine("Value of Previous Node: " + current.Previous.Value);		

			// 'FindLast()' scans from end to start and returns node with given value
			Console.WriteLine("Node with Value 2: " + l1.FindLast(2).Value);

			l1.AddBefore(current, 7);
			Console.WriteLine("Adding 7 before Node 6: ");
			Display(l1);

			l1.AddAfter(current, 15);
			Console.WriteLine("Adding 15 after Node 6: ");
			Display(l1);


			l1.Remove(3);
			Console.WriteLine("Deleting Node of Value 3: ");
			Display(l1);

			l1.RemoveFirst();
			Console.WriteLine("Deleting First Node Directly: ");
			Display(l1);

			current = l1.First;
			l1.Remove(l1.First);            // Same 'Remove()' method deletes node as well
			Console.WriteLine("Deleting First Node with Pointer: ");
			Display(l1);


			l1.AddLast(current);
			Console.WriteLine("Putting Deleted First Node at Last: ");
			Display(l1);

			l1.RemoveLast();
			Console.WriteLine("Deleting Last Node Directly: ");
			Display(l1);

			l1.Remove(l1.Last);
			Console.WriteLine("Deleting Last Node with Pointer: ");
			Display(l1);
		}
	}
}