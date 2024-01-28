// Allows us to use the namespace known as 'System' 
using System;

// Defining custom namespace(Collection of classes)
namespace HelloWorld
{
    // Defining custom class name
    public class MyProgram
    {
		// 'Main()' specifies what the 'class' does when executed
        // Function to be executed first should be 'Main()' function 
        // Main function takes array of string as optional parameter
        // Here, 'static' allows us to run method without creating object 
        static void Main(string[] args)
        {
            // 'System' allows us to use 'Console' class
            //System.Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");

			// Added this line to stop terminal from self closing
			Console.ReadLine();
			// Console.ReadKey();		// Reads a single key stroke
        }
    }
}