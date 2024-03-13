using System;

namespace PropertyApp
{
	public class Student
	{
		public string Name { get; set; }            // Auto-Property
		private static int _Count = 0;
		public int Count                            // Read-Only Property
		{
			get
			{
				return _Count;
			}
		}
		public Student()
		{
			_Count++;
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Student s1 = new Student();
			s1.Name = "Ram";

			Console.WriteLine(s1.Name);
			Console.WriteLine(s1.Count);
		}
	}
}