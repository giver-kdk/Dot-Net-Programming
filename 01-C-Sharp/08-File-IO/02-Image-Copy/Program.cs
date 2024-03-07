using System;

namespace ImageCopyProgram
{
	public class Program
	{
		public static void Main(string[] args)	
		{
			// File path of source file
			string srcFilePath = @"D:\CODES\Dot-Net-Development\01-C-Sharp\ConsoleProgram\Sky.jpg";
			// File path of destination file
			string destFilePath = @"D:\CODES\Dot-Net-Development\01-C-Sharp\ConsoleProgram\Hill.jpg";

			// 'Copy(Source, Destination, Overwrite)'
			File.Copy(srcFilePath, destFilePath, true);         // Default for overwrite is 'false'
			// NOTE: Setting overrwrite to 'false' only supports copy pasting the file
		}
	}
}
