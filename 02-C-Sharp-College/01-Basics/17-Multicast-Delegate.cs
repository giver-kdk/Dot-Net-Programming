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
            // First, create an class's object to reference the method 
            Program p1 = new Program();

            MyDelegate md2 = p1.PrintArea + p1.PrintPerimeter;              // Set multiple target methods. Order matters for execution.
            md2(5, 2);                                                      // Calls both methods
            md2 = md2 - p1.PrintArea;                                       // Detaches the pointer to function which is being subtracted
            md2(6, 3);                                                      // Calls only one method

            // PROBLEM: We can't simply get the returned value of multiple methods pointed by delegate
            MyDelegate md3 = p1.GetArea + p1.GetPerimeter;              // Set multiple target methods that return some value
            double result = md3(5, 2);                                  // Here, response of last method overrides 'result' value
            Console.WriteLine("Result is: {0}", result);

            // SOLUTION: We can get the returnd value of multiple methods pointed by delegate by extracting it during invocations
            foreach(var deleg in md3.GetInvocationList)
            {
                double res = deleg();
                Console.WriteLine(res);
            } 
        }
    }
}