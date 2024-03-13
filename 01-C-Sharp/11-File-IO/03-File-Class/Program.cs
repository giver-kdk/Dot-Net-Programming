using System;
using System.IO;                    // 'File' class located here

namespace FileApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string fileName = @"C:\Users\DELL\Documents\TestFolder\test1.txt";
			// Write array data in different lines of file
			string[] data = { "Ram", "Shyam", "Hari" };
			// File is created automatically(But, not folder) if file doesn't exist
			File.WriteAllLines(fileName, data);

			// Read file line by line
			foreach (string s in File.ReadAllLines(fileName))
			{
				Console.WriteLine(s);
			}
		}
	}
}
