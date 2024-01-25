using System;

namespace HelloWorld
{
	public class MyProgram
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello 1");			// This won't get displayed
			// 'Console' class provides many methods like; 
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Green;
			// Clears the screen + Background Color is apoplied to entire Window
			Console.Clear();
			Console.WriteLine("Hello 2");
		}
	}
}