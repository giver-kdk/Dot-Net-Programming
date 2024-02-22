using System;

namespace MultipleInheritance
{
    public class MyClass1
    {
        public void ShowInfo()
        {
            Console.WriteLine("This is Class 1");
        }
    }
    public class MyClass2
    {
        public void ShowInfo()
        {
            Console.WriteLine("This is Class 2");
        }
    }
    public interface IMyInterface1
    {
        public void Greet();
    }
    public interface IMyInterface2
    {
        public void ShowInfo();
    }

    // Multiple inheritance allowed with interface. Here, only 1 class can be used for inheritance
    // public class Child : MyClass1, MyClass2, IMyInterface1, IMyInterface2         // Not Allowed

    public class Child : MyClass1, IMyInterface1, IMyInterface2
    {
        // Implementation for IMyInterface1
        public void Greet()
        {
            Console.WriteLine("This is interface 1");
        }
        // Implementation for IMyInterface2
        public void ShowInfo()
        {
            Console.WriteLine("This is interface 2");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Child c1 = new Child(); 
            c1.Greet(); 
            c1.ShowInfo();
        }
    }
}
