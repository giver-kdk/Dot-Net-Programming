// Abstract Methods are simply dynamic 'Polymorphism' 
using System;

namespace AbstractClass
{
    // If a class is 'abstract' then it means, it is incomplete and 
    // Some features needs to be implemented by AbstractChild classes to be complete
    public abstract class Parent           // Class should be abstract if atleast one method is abstract
    {
        // Abstract methods should only be declared(not defined). It must be implemented by AbstractChild class
        // It is only allowed inside 'abstract' class.
        // It is just a indication that AbstractChild classs should define this method by overriding
        public abstract void ShowInfo();
        public abstract void Display();
    }
    abstract public class AbstractChild : Parent
    {
        // Overwriding abstract method of parent class
        public override void ShowInfo()
        {
            Console.WriteLine("I am Abstract Child");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // It is only supposed to be a base class for other classes to inherit it
            //Parent p1 = new Parent();         // Can't instanciate abstract parent class

            // AbstractChild c1 = new AbstractChild();          // Can't instanciate abstract child class
            // c1.ShowInfo();
        }
    }
}