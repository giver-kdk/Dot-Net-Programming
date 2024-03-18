using System;
using System.IO;                    // 'File' class located here

namespace FileApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string fileName = @"C:\Users\DELL\Documents\TestFolder\myFile.txt";
			// Write array data in different lines of file
			Console.Write("Enter data to write: ");
			string data = Console.ReadLine();
			// File is created automatically(But, not folder) if file doesn't exist
			File.WriteAllText(fileName, data);

			// Read file line by line
			Console.WriteLine(File.ReadAllText(fileName));
			Console.WriteLine("Lab No: 12");
			Console.WriteLine("Name: Giver Khadka");
			Console.WriteLine("Roll No.: 05");
		}
	}
}
