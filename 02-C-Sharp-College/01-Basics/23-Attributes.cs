using System;

namespace AttributeApp
{
    [AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Struct |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Property |
    AttributeTargets.Method,
    AllowMultiple = true)]              // Allowing multiple instances of attribute
    public class BugAttribute : Attribute
    {
        public string Name { get; set; }
        public string Developer { get; set; }
        public string Date { get; set; }
        public BugAttribute() { }
        public BugAttribute(string n, string dev)
        {
            Name = n;
            Developer = dev;
        }
    }
    [Bug("Syntax Error", "Alex", Date = "2020-03-5")]
    [Bug("For Loop Bug", "John", Date = "2020-03-6")]
    public class Program
    {
        public static void Main(string[] args)
        {
            var attr = Attribute.GetCustomAttributes(typeof(Program));
            foreach (var a in attr)
            {
                Console.WriteLine(a);
            }
            //BugAttribute attribute = (BugAttribute)Attribute.GetCustomAttribute(
            //typeof(Program).GetMethod("Main"),
            //typeof(BugAttribute));

            //if (attribute != null)
            //{
            //    Console.WriteLine($"Description: {attribute.Name}");
            //}
        }
    }
}