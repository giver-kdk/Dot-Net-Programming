using System;
using System.IO;                    // 'DirectoryInfo' located here

namespace DirectoryInfoApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Getting Current Directory Info
			DirectoryInfo currentDir = new DirectoryInfo(".");
			Console.WriteLine(currentDir.Name);             // Current Folder Name	
			Console.WriteLine(currentDir.FullName);         // Absolute Path
			Console.WriteLine(currentDir.Parent);           // 1 Step higher parent directory path
			Console.WriteLine(currentDir.Attributes);       // Returns type of directory pointed

			// Accessing other Directory
			DirectoryInfo myDir = new DirectoryInfo(@"C:\Users\DELL\Documents\TestFolder");
			myDir.Create();                                 // Creating the directory

			// Deleting directory
			Console.Write("Do you want to delete the folder (Y/N): ");
			string? choice = Console.ReadLine();
			if (choice == "Y" || choice == "y")
			{
				myDir.Delete();                             // Only deletes empty directory
															// myDir.Delete(true);						// Deletes non-empty directory as well. Here, 'true' means 'recursive'
				Console.WriteLine("Folder is deleted");
			}
			else
			{
				Console.WriteLine("Folder is not deleted");
			}
		}
	}
}
