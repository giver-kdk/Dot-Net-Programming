using System;
using System.IO;                    // 'FileInfo' class located here
									// NOTE: ***********	Run Visual Studio IDE as Administration to get access permission	***********
									// Directory is a static class used for working with Directory
									// We can't instantiate from this static class 
namespace FileStreamApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string sourceDir = @"C:\Users\DELL\Documents\TestFolder1";
			string sourceFile = @"C:\Users\DELL\Documents\TestFolder1\SourceFile.txt";
			string destDir = @"C:\Users\DELL\Documents\TestFolder2";

			if (!Directory.Exists(sourceDir))                                   // Returns 'true' if directory exists else 'false'
			{
				Directory.CreateDirectory(sourceDir);                           // Creating 1st Directory
			}

			FileStream fs = new FileStream(sourceFile, FileMode.Create);        // Create a file using FileStream
			fs.Close();                                                         // Close the stream to free the file

			try
			{
				// Moves content of source directory to destination direcotry and deletes source directory
				Directory.Move(sourceDir, destDir);                             // Might not have access to move file
				Console.WriteLine("File Content Moved...");
			}
			catch (Exception err)
			{
				Console.WriteLine("Can't Move File Content...");
				Console.WriteLine(err.Message);
			}

			// 'Directory.EnumerateDirectories()' returns collection of all the directories inside
			foreach (string path in Directory.EnumerateDirectories(@"C:\Users\DELL\Documents"))
			{
				Console.WriteLine(path);
			}

			// In 'Directory.Delete(path, recursive)', setting 'recursive' to 'true' deletes all nested files as well
			Console.ReadLine();                                             // Hold program for a while
			Directory.Delete(destDir, true);                                // Delete the directory and it's content
		}
	}
}
