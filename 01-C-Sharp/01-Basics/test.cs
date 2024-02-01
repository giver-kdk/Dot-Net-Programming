// Allows us to use the namespace known as 'System' 
using System;

// Defining custom namespace
namespace HelloWorld
{
    // Defining custom class name
    public class MyProgram
    {
        // Function to be executed first should be 'Main()' function 
        // Main function takes array of string as optional parameter
        // Here, 'static' allows us to run method without creating object 
        static void Main(string[] args)
        {
            object name = 2;
			Console.WriteLine(name);

			name = "Giver";
			Console.WriteLine(name);

        }
    }
}