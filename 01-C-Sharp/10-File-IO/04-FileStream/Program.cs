using System;
using System.IO;                    // 'FileInfo' class located here
using System.Text;                  // 'Encoding' class located here

// FileStream is used for working with specific part of the file
// The part of file is represented by 'byte' array
namespace FileStreamApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// WRITE FileStream: String -> Byte Array -> Write
			string myFile = @"C:\Users\DELL\Documents\TestFolder\test2.txt";
			// 'FileMode' allows us to open, create, append as per situation
			// 'FileMode.Create' creates file if it doesn't exist
			FileStream fs = new FileStream(myFile, FileMode.Create);

			// Writing stream in file requires us to convert string into byte array
			string data = "Hello I am a text";
			// Using system's default character encoding method, convert string to bytes
			byte[] dataBytes = Encoding.Default.GetBytes(data);
			// Here, In 'FileStream.Write(data, index, count)', 'count' is the max number of bytes to write
			fs.Write(dataBytes, 0, dataBytes.Length);





			// Reset cursor after writing
			fs.Position = 0;

			// READ FileStream: Read -> Byte Array -> String
			// Read the byte array and convert to string
			List<byte> resultBytes = new List<byte>();                  // Making resizable byte array
			for (int i = 0; i < dataBytes.Length; i++)
			{
				resultBytes.Add((byte)fs.ReadByte());
			}
			// 'GetSting()' takes array of 'byte'. So convert from list to array
			string resString = Encoding.Default.GetString((resultBytes.ToArray()));
			Console.WriteLine(resString);

			// Close stream after use
			fs.Close();
		}
	}
}
