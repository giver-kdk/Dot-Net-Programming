using System;
using System.IO;                    // 'FileInfo' class located here

namespace FileInfoApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Directly get information about specified/known file
			FileInfo info1 = new FileInfo(@"C:\Users\DELL\Documents\TestFolder\test1.txt");
			Console.WriteLine(info1.Name);                      // Gives file name
			Console.WriteLine(info1.FullName);                  // Gives file full path
			Console.WriteLine(info1.Length);                    // Gives file size
			Console.WriteLine(info1.CreationTime);              // Gives file time of creation
			Console.WriteLine(info1.Attributes);                // Gives file type
			Console.WriteLine(info1.Extension);                 // Gives file extension name
			Console.WriteLine(info1.IsReadOnly);                // Gives 'true' if file is readony else 'false'
			Console.WriteLine(info1.LastAccessTime);            // Gives time when file was last accessed

			// Get file information by searching in particular directory
			DirectoryInfo myDir = new DirectoryInfo(@"C:\Users\DELL\Documents\TestFolder");
			// 'SearchOption.AllDirectories' searches on all nested levels of directory
			FileInfo[] myFiles = myDir.GetFiles("*.txt", SearchOption.AllDirectories);      // '*txt' is regex for text file
			foreach (FileInfo file in myFiles)
			{
				Console.WriteLine(file.Name);
				Console.WriteLine(file.Length);
			}
		}
	}
}
