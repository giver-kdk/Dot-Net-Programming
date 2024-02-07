using System;
using System.Runtime.Intrinsics.X86;

namespace Displayer
{
    public class Box
    {
        public double length, breadth, height;
        // Compiler makes default constructor if no constructor created
        // That Default constructor gives default value to fields
        // If number, then '0' assigned
        // If string/reference type, then 'null' assigned
        
        // Non-Parameterized Constructor (Some call it Default Constructor)
        public Box()
        {
            length = 5.5;
            breadth = 5.5;
            height = 5.5;
        }
        // Parameterized Constructor (Some call it Default Constructor)
        public Box(double length, double breadth, double height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }
        public void Display()
        {
            Console.WriteLine("Length: " + length + "\nBreadth: " + breadth + "\nHeight: " + height);
        }
        public void SetDimension(double l, double b, double h)
        {
            length = l;
            breadth = b;
            height = h;
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
            b1.Display();               // Prints default value
            Console.WriteLine();

            b1.length = 10;
            b1.breadth = 10;
            b1.height = 10;
            b1.Display();

            Console.WriteLine();

            Box b2;             // This is not an object now. This is a reference variable
            b2 = new Box();     // Now, b2 is a object(which we know is a reference type)
            b2.SetDimension(20, 20, 20);
            b2.Display();

            Console.WriteLine();

            // Another way to create object
            Box b3 = new Box()
            {
                length = 30,
                breadth = 30,
                height = 30
            };
            b3.Display();
        }
    }
}