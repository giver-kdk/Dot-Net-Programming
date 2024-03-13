using System;
using System.Runtime.CompilerServices;

namespace ConstructorTypes
{
	public class Student
	{
		public string name;
		public static int count = 0;
		// Default Constructor
		public Student()
		{
			name = "No Name";
			count++;
		}
		// Parameterized Constructor
		public Student(string n)
		{
			name = n;
			count++;
		}
		// Copy Constructor
		public Student(Student obj)
		{
			name = obj.name;
			count++;
		}
		// Private Constructor
		private Student(string n, int c)
		{
			name = n;
			count = c;
		}
		// Static Constructor
		static Student()            // Runs anyway before Main() method
		{
			count = 100;
		}
		public void DisplayInfo()
		{
			Console.WriteLine("Name: " + name);
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Student s1 = new Student();
			s1.DisplayInfo();
			Student s2 = new Student("Ram");
			s2.DisplayInfo();
			Student s3 = new Student(s2);
			s3.DisplayInfo();
			//Student s4 = new Student("Shyam", 10);          // Private Class Restriction

			Console.WriteLine("Count: " + Student.count);
		}
	}
}