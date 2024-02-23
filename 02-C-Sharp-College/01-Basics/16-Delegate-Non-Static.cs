using System;
// Delegate can point to different methods which matches the signature of the delegate
// Delegate can be declared both inside and outside the class

namespace DelegateApp
{
    public class Program
    {
        // Delegate declaration with a signature
        public delegate void MyDelegate(string msg);
        // This method can be pointed by our delegate
        public void MethodA(string message)        
        {
            Console.WriteLine(message);
        }
        public static void Main(string[] args)
        {
            // First, create an object 
            Program p1 = new Program();

            // Method 1 ********************
            // Set target method
            MyDelegate md1 = new MyDelegate(p1.MethodA);    // Pass method name in the delegate constructor
            // 'md1' is now a delegate instance. 'md' is now alias for 'MethodA'
            // Invoke the delegate
            md1.Invoke("Hello World");                   // Pass parameter in 'Invoke()'


            // Method 2 ********************
            MyDelegate md2 = p1.MethodA;                    // Another way to set target method
            md2("Hello World");                          // Another way to invoke delegate
        }
    }
}