// Generics is similar to 'Template' is C#
// It allows us to create methods whose parameter type is unknown
// Boxing: Convert Primitive type to Object Type
// Unboxing: Convert Object type to Primitive Type
using System;

namespace GenericsApp
{
    public class MyClass
    {
        public void DisplayValue(int n)
        {
            Console.WriteLine(n);
        }
        // Generic method where 'T' is unknown data type
        public void ShowValue<T>(T value)
        {
            Console.WriteLine(value);
        }
        // Generic with multiple parameters
        public void ShowValue<T, Z>(T value1, Z value2)
        {
            Console.Write(value1);
            Console.WriteLine(value2);
        }
        // This works like Generic, but it is less efficient due to auto Boxing and Unboxing process
        public void PrintValue(object n)                
        {   
            Console.WriteLine(n);              // Unboxing happens here         
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass m1 = new MyClass();
            Console.WriteLine("Normal Method");
            m1.DisplayValue(5);
            // m1.DisplayValue("Five");          // This is not allowed in normal method

            Console.WriteLine("Generic Method");
            m1.ShowValue<int>(5);               // Strictly specifying parameter type. It is Type Safe
            m1.ShowValue<float>(10.5f);
            m1.ShowValue<double>(20.6d);
            m1.ShowValue<string>("Five");
            // Calling multiple parametered Generic
            m1.ShowValue<int, string>(50, " Rupees");

            // AVOID This: If type not mentioned, then it automatically does boxing/unboxing or typecasting
            m1.ShowValue(10);                   // Not mentioning parameter type. It is not Type Safe. 

            Console.WriteLine("Inefficient Method");
            m1.PrintValue(5);                   // Boxing happens here
            m1.PrintValue("Five");
        }
    }
}