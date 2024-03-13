using System;
using System.IO;                    // 'FileInfo' class located here

// BinaryWriter writes binary format data in the stream of file
// BinaryReader reads from binary stream
// They preserve the data type of the data stored.
namespace BinaryRWApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// '.dat' file is a generic file type that stores data in binary format.
			// Hence, it allows to store text, image, audio, video, etc.
			string myDATFile = @"C:\Users\DELL\Documents\TestFolder\test4.dat";
			FileStream myStream = new FileStream(myDATFile, FileMode.Create);

			// BINARY WRITE
			BinaryWriter bw = new BinaryWriter(myStream);           // We have to write inside a writable stream
			string name = "Giver Khadka";
			int age = 21;
			bool isStudent = true;
			bw.Write(name);
			bw.Write(age);
			bw.Write(isStudent);
			// Close Binary Writer after use
			bw.Close();

			// BINARY READ
			// 'FileMode.Open' opens file allowing us to read/write in it
			myStream = new FileStream(myDATFile, FileMode.Open);    // We have to read from a readable stream
			BinaryReader br = new BinaryReader(myStream);
			Console.WriteLine(br.ReadString());
			Console.WriteLine(br.ReadInt32());
			Console.WriteLine(br.ReadBoolean());

		}
	}
}
