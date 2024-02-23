using System;
// Delegate can point to different methods which matches the signature of the delegate
// Delegate can be declared both inside and outside the class

namespace DelegateApp
{
    public class Program
    {
        // Delegate declaration with a signature
        public delegate void MyDelegate(string msg);

        public static void MethodA(string message)         // This method can be pointed by our delegate
        {
            Console.WriteLine(message);
        }
        public static void Main(string[] args)
        {
            // Method 1 ********************
            // Set target method
            MyDelegate md1 = new MyDelegate(MethodA);    // Pass method name in the delegate constructor
            // 'md1' is now a delegate instance. 'md' is now alias for 'MethodA'
            // Invoke the delegate
            md1.Invoke("Hello World");                   // Pass parameter in 'Invoke()'


            // Method 2 ********************
            MyDelegate md2 = MethodA;                    // Another way to set target method
            md2("Hello World");                          // Another way to invoke delegate
        }
    }
}