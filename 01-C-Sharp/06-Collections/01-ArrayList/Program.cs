using System;
// 'using System' doesn't import nested namespaces. So, we import 'System.Collections' manually
using System.Collections;           // Contains 'ArrayList' class

namespace ArrayListProgram
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// '#region' and '#endregion' allows code to expand and collapse like scope
			#region basics			
			// 'ArrayList' is a resizable array unlike normal array
			ArrayList aList1 = new ArrayList();
			// We can add elements just like Push() in C++
			aList1.Add("Ram");
			aList1.Add(21);             // Different data types is allowed

			foreach (object obj in aList1)
			{
				Console.WriteLine(obj);
			}
			Console.WriteLine();


			ArrayList aList2 = new ArrayList();
			// Adding ArrayList inside ArrayList
			aList2.AddRange(aList1);
			// Adding array inside ArrayList
			aList2.AddRange(new object[] { "Shyam", 19, 05 });

			foreach (object obj in aList2)
			{
				Console.WriteLine(obj);
			}
			Console.WriteLine();


			Console.WriteLine(aList2.Count);              // Number of elements
			Console.WriteLine(aList2.Capacity);           // Total elements capacity
			Console.WriteLine();

			#endregion

			ArrayList aList3 = new ArrayList();
			aList3.Add("Giver");                        // String
			aList3.Add("Ram");                          // String
			aList3.Add("Alex");                         // String
			aList3.Sort();                              // Sorts elements(Data types of elements should be same)
			foreach (object obj in aList3)
			{
				Console.WriteLine(obj);
			}


			Console.WriteLine();
			aList3.Reverse();                           // Reverse elements(Data types of elements can be different)
			foreach (object obj in aList3)
			{
				Console.WriteLine(obj);
			}
			Console.WriteLine();


			// Insert elements at specific index
			aList3.Insert(0, "Brian");
			aList3.Insert(0, "Smith");
			aList3.Insert(0, "Ben");

			foreach (object obj in aList3)
			{
				Console.WriteLine(obj);
			}
			Console.WriteLine();

			aList3.RemoveAt(0);                     // Remove element in index 0
			aList3.RemoveRange(0, 2);               // Remove element from index [0, 2)
			foreach (object obj in aList3)
			{
				Console.WriteLine(obj);
			}
			Console.WriteLine();


			// Get index of particular element. 'IndexOf()' retutn -1 on failure
			Console.WriteLine("Index of Alex: {0}", aList3.IndexOf("Alex"));
			Console.WriteLine();


			// Convert ArrayList to string array. We need to do TypeCasting(to string[]) because there might be data loss
			// 'typeof' is needed to specify the type of each element of resulting array
			string[] strArray = (string[])aList3.ToArray(typeof(string));
			foreach (string str in strArray)
			{
				Console.WriteLine(str);         // Elements of 'aList3' converted to string
			}
			Console.WriteLine();


			// Convert string array to ArrayList
			string[] people = { "Ram", "Shyam", "Hari" };
			ArrayList aList4 = new ArrayList();
			aList4.AddRange(people);            // Array to ArrayList conversion 
			foreach (object obj in aList4)
			{
				Console.WriteLine(obj);
			}
			Console.WriteLine();
		}
	}
}