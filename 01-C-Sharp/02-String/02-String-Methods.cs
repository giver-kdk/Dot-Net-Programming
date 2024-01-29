using System;

namespace StringMethod
{
	public class Program
	{
		static void Main(string[] args)
		{
			string sentence = "I am Giver Khadka";
			string name = "I am giver khadka";

			// Find string length. Remember capital 'L' for 'Length' 
			Console.WriteLine("String length: {0}", sentence.Length);
			// Search substring in string. Just like 'includes' in JS
			Console.WriteLine("String has 'Giver': {0}", sentence.Contains("Giver"));
			// Find 1st encountered index of specified substring
			Console.WriteLine("Index of 'Khadka' is: {0}", sentence.IndexOf("Khadka"));
			// Concat multiple strings. It doesn't modify orginal string. So, we assigned it
			sentence = String.Concat(sentence, ". I live in Nepal");
			Console.WriteLine("Concatination: {0}", sentence);
			// Replaces all particular substrings with another
			sentence = sentence.Replace("Nepal", "Kathmandu");
			Console.WriteLine("Replacement: {0}", sentence);
			// Remove substring form specified index to specified length
			// Syntax: 'Remove(startIndex, deleteLength)'
			sentence = sentence.Remove(11, 6);
			Console.WriteLine("After Remove: {0}", sentence);
			// Insert substring form specified index to specified length
			// Syntax: 'Insert(startIndex, insertString)'
			sentence = sentence.Insert(11, "Kdk");
			Console.WriteLine("After Insert: {0}", sentence);


			// Copying one string to another
			// string newString = String.Copy(sentence);
			string newString = sentence;
			Console.WriteLine("Copied String: {0}", newString);
			// Compare string with 'String.Compare(string str1, string str2, bool ignoreCase)'
			// It return '0' is strings equal else +ve or -ve value. We need 'String' class 
			Console.WriteLine("Strings are same: {0}", String.Compare(sentence, name, true));


			// Padding reserves specified space and fills remaining space with specified 'char'
			// Syntax: 'PadLeft(reservingSpace, fillerChar)'. It doesn't modify original string
			Console.WriteLine("Left Padding: {0}", sentence.PadLeft(50, '.'));
			Console.WriteLine("Right Padding: {0}", sentence.PadRight(50, '.'));
			// Convert entire string to upper case. It also doesn't modify original string
			Console.WriteLine("Uppercased String: {0}", sentence.ToUpper());
			Console.WriteLine("Lowercased String: {0}", sentence.ToLower());


			// Creating string according to variable value using 'Format()' method
			int age = 19;
			string address = "Chitwan";
			string info = String.Format("He is {0} years old. He live in {1}.", age, address);
			Console.WriteLine("Format Created String: {0}", info);
			// Avoiding escape characters like '\n', '\t', '\', etc using '\'
			Console.WriteLine("Methods 1 Avoid Escape Character: \\n and \\t and \\");
			// Avoiding escape characters using '@'
			Console.WriteLine(@"Methods 2 Avoid Escape Character: \n and \t and \");


			// Remove whitespace from front and back of string. It doesn't modify the original string
			string greet = "          Hello World        ";
			Console.WriteLine("Before Trimmed: {0}", greet);
			Console.WriteLine("After Trimmed: {0}", greet.Trim());


			// Convert Array to String. It also doesn't modify the original array
			string[] countryArray = {"Nepal", "China", "India"};
			string countries = String.Join(" and ", countryArray);
			Console.WriteLine("Array joined to String: {0}", countries);
			// Convert String to Array. It also doesn't modify the original string
			// NOTE: 'Split()' arguments should be array of character, not string
			// string[] newCountryArray = countries.Split(' ');
			// NOTE: For 'Split()' argument to be array of string, use 'StringSplitOption.None'
			string[] separator = {" and "};
			string[] newCountryArray = countries.Split(separator, StringSplitOptions.None);
			Console.WriteLine("String splitted to Array[0]: {0}", newCountryArray[0]);
			Console.WriteLine("String splitted to Array[1]: {0}", newCountryArray[1]);
			Console.WriteLine("String splitted to Array[2]: {0}", newCountryArray[2]);


			// Check if string is empty or not using 'IsNullOrEmpty()'
			string emptyString = "";
			if(String.IsNullOrEmpty(emptyString)) Console.WriteLine("Empty");
			else Console.WriteLine("Not Empty");
		}
	}
}