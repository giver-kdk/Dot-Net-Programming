using System;
using System.Collections;
// 'Hashtable' is conceptually same as 'Dictionary' but it is Non-Generic. So, there is no type safety
// It also stores key-value pair of data. They key and value can be of any data type
// The items in hashtable gets stored according to hash code for keys. 
// So, items may appear in random order due to use of hash code(generated randomly from hash function)

namespace HashtableApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Hashtable family = new Hashtable();
			// We can add key-value of any data type
			family.Add("father", "Ram");
			family.Add("mother", true);
			family.Add("son", "Shyam");
			family.Add(4, "Gopal");

			// Delete item by specifying key
			family.Remove("mother");
			Console.WriteLine($"Hashtable Length: {family.Count}");
			Console.WriteLine($"Father is: {family["father"]}");            // Accessing value from key
			Console.WriteLine($"Hashtable has 'father' key: {family.ContainsKey("father")}");
			Console.WriteLine($"Hashtable has 'Gopal' value: {family.ContainsValue("Gopal")}");

			// Hashtable traversal same as Array Traversal 
			Console.WriteLine("Hashtable Traversal:");
			foreach (DictionaryEntry item in family)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}


			// Clearing Hashtable
			family.Clear();
			Console.WriteLine("After Clearing Hashtable:");
			foreach (DictionaryEntry item in family)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}
		}

	}
}