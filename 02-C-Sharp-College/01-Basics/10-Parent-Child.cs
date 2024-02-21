// 'Object' class is the super class of all the classes. 
using System;

namespace InheritanceWAP
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Parent(int i, string n)
        {
            Id = i;
            Name = n;
        }
        public virtual void Display()
        {
            Console.WriteLine("I am Parent");
        }
    }
    public class Child : Parent
    {
        public int Age { get; set; }

        public Child(int i, string n, int a) : base(i, n)
        {
            Age = a;
        }
        public override void Display()
        {
            Console.WriteLine("I am Child");
            Console.WriteLine("Age is: " + Age);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // We can use parent reference variable to store child instance. But vice-versa is not true
            Parent p1;
            p1 = new Child(123, "Ram", 21);
            Console.WriteLine(p1.Id);         // Can access parent's members
            Console.WriteLine(p1.Name);         // Can access parent's members
            // Console.WriteLine(p1.Age);       // Can't access child's members

            p1.Display();                       // Can run the overridden method
        }
    }
}