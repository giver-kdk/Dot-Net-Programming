using System;
using System.Collections.Generic;
// 'Dictionary' is conceptually same as 'Hashtable' but it is Generic. So, there is type safety and prevents accidental type mismatch

namespace DictionaryApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// 'Dictionary' is the 'key-value' pair data structure
			// 'Dictionary' is named so because dictionaries show meaning of words(keys)
			// Here, '<string, string>' is <key_data_type, value_data_type>
			Dictionary<string, string> family = new Dictionary<string, string>();

			family.Add("father", "Ram KC");         // Add key value pair
			family.Add("mother", "Sita KC");
			family.Add("son", "Gopal KC");

			// Displaying 'Dictionary' key value pairs. Here also, <string, string> means key and value data types
			// Here, 'KeyValue' is a struct type
			foreach (KeyValuePair<string, string> member in family)
			{
				Console.Write(member.Key + ": " + member.Value + "\n");
			}
			Console.WriteLine();

			Console.WriteLine("Dictionary Length: {0}", family.Count);
			// Accessing value from key
			Console.WriteLine($"Father is: {family["father"]}");
			// Check is there exists particular 'key' in the dictionary
			Console.WriteLine("Dictionary contains 'father' key: {0}", family.ContainsKey("father"));
			// Check is there exists particular 'value' in the dictionary
			Console.WriteLine("Dictionary contains 'Gopal KC' value: {0}", family.ContainsValue("Gopal KC"));

			// Removing Dictionary items using the 'key' 
			family.Remove("son");
			foreach (KeyValuePair<string, string> member in family)
			{
				Console.Write(member.Key + ": " + member.Value + "\n");
			}

			// Check if there exists value for particular key and store it if found
			// 'TryGetValue' returns True and stores value in 'out' variable if 'value' found for 'key'
			bool valueExists = family.TryGetValue("mother", out string? parsedValue);
			Console.WriteLine("Value Exists: {0}", valueExists);
			Console.WriteLine("Parsed Value: {0}", parsedValue);
			Console.WriteLine();


			// Deleting all key-value pairs of Dictionary
			family.Clear();
			Console.WriteLine("After Clearing Dictionary: ");
			foreach (KeyValuePair<string, string> member in family)
			{
				Console.Write(member.Key + ": " + member.Value + "\n");
			}
		}
	}
}