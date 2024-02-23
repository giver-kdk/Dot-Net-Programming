using System;
// Delegate pointing to multiple methods is called multilcast delegate
// It is needed when we multiple methods have same signature and parameters

namespace DelegateApp
{
    public class Program
    {
        // Delegate declaration with a signature
        public delegate void MyDelegate(double p1, double p2);
        // Method not returning anything
        public void PrintArea(double l, double b){
            Console.WriteLine(l * b);
        }
        public void PrintPerimeter(double l, double b){
            Console.WriteLine(2 * (l + b));
        }

        // Methods returning some value
        public double GetArea(double l, double b){
            return (l * b);
        }
        public double GetPerimeter(double l, double b){
            return (2 * (l + b));
        }
        public static void Main(string[] args)
        {
            // First, create an object 
            Program p1 = new Program();

            // Method 1 ********************
            // Set target method
            MyDelegate md1 = new MyDelegate(p1.PrintArea);    // Pass method name in the delegate constructor
            // 'md1' is now a delegate instance. 'md' is now alias for 'MethodA'
            // Invoke the delegate
            md1.Invoke("Hello World");                   // Pass parameter in 'Invoke()'


            // Method 2 ********************
            MyDelegate md2 = p1.MethodA;                    // Another way to set target method
            md2("Hello World");                          // Another way to invoke delegate
        }
    }
}