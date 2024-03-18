using System;
using System.Collections;                   // Contains 'ArrayList' class

namespace ArrayListProgram
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ArrayList aList1 = new ArrayList();
			aList1.Add("Ram");
			aList1.Add(21);                 // Different data types is allowed
			aList1.Insert(0, "Shyam");                      // Insert item at index 0

			// Accessing element with the help of index
			Console.WriteLine(aList1[0]);                   // Output: Ram
			Console.WriteLine(aList1[1]);                   // Output: Shyam
			Console.WriteLine(aList1.Count);                // Output: 3
			Console.WriteLine(aList1.Capacity);             // Output: 4

			aList1.RemoveAt(2);                             // Remove element from index 2
															// ArrayList traversal is same as Array traversal 
			foreach (object obj in aList1)
			{
				Console.WriteLine(obj);
			}
			Console.WriteLine("Lab No: 10a");
			Console.WriteLine("Name: Giver Khadka");
			Console.WriteLine("Roll No.: 05");
		}
	}
}