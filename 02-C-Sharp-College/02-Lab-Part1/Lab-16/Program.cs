using System;

namespace AttributeApp
{	// Built in Attribute
	[AttributeUsage(
	AttributeTargets.Class |
	AttributeTargets.Struct |
	AttributeTargets.Constructor |
	AttributeTargets.Field |
	AttributeTargets.Property |
	AttributeTargets.Method,
	AllowMultiple = true)]            
	public class BugAttribute : Attribute               // Custom Attribute
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
			Console.WriteLine("Lab No: 16");
			Console.WriteLine("Name: Giver Khadka");
			Console.WriteLine("Roll No.: 05");
		}
	}
}