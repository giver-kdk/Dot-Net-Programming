using System;
using System.Runtime.Intrinsics.X86;

namespace Displayer
{
    public class Box
    {
        public double length, breadth, height;
        public void Display()
        {
            Console.WriteLine("Length: " + length + "\nBreadth: " + breadth + "\nHeight: " + height);
        }
    }
    public class Test
    {
        // For .NET, 'Main()' method called by CLR, not by the OS 
        // 'args' stores the arguments passes to 'Main()' function from terminal
        public static void Main(string[] args)
        {
            // We are only allowed to create dynamic object using 'new' in C#
            // Dynamic object stored in Heap Memory
            Box b1 = new Box();
            b1.length = 10;
            b1.breadth = 10;
            b1.height = 10;
            b1.Display();
        }
    }
}