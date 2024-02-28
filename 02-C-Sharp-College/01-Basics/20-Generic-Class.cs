// Generics is similar to 'Template' is C#
using System;

namespace GenericsExampleApp
{
    public class MyClass<T>                        // Generic Class: Class of unknown type 'T'
    {
        // Normal Method that uses 'T' data type provided by class
        public void Sum(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            // Console.WriteLine(x + y);           // We can't directly perform operation of unknown types
            Console.WriteLine($"Sum is: {a + b}");
        }
        public void Mul(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            Console.WriteLine($"Product is: {a * b}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass<int> m1 = new MyClass<int>();       // The object is of type 'int' now
            m1.Sum(5, 6);
            m1.Mul(10, 20);

            MyClass<float> m2 = new MyClass<float>();   // The object is of type 'float' now
            m2.Sum(5.5f, 4.5f);
            m2.Mul(9.5f, 19.5f);

            MyClass<string> m3 = new MyClass<string>();   // The object is of type 'float' now
            m3.Sum("Hello", "World");
        }
    }
}