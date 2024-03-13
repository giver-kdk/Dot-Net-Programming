using System;

namespace IntegerIndexer
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		// Interger Indexer
		public object this[int i]
		{
			get
			{
				if (i == 0) return Id;
				else if (i == 1) return Name;
				else if (i == 2) return Age;
				else return -1;
			}
			set
			{
				if (i == 0) Id = (int)value;
				else if (i == 1) Name = (string)value;
				else if (i == 2) Age = (int)value;
				else return;
			}
		}
		// String Indexer
		public object this[string str]
		{
			get
			{
				if (str == "id") return Id;
				else if (str == "name") return Name;
				else if (str == "age") return Age;
				else return -1;
			}
			set
			{
				if (str == "id") Id = (int)value;
				else if (str == "name") Name = (string)value;
				else if (str == "age") Age = (int)value;
				else return;
			}
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Student s1 = new Student();
			s1[0] = 123;
			s1[1] = "Ram";
			s1[2] = 21;
			Console.WriteLine(s1[0]);
			Console.WriteLine(s1[1]);
			Console.WriteLine(s1[2]);

			Console.WriteLine();
			Student s2 = new Student();
			s2["id"] = 456;
			s2["name"] = "Shyam";
			s2["age"] = 19;
			Console.WriteLine(s2["id"]);
			Console.WriteLine(s2["name"]);
			Console.WriteLine(s2["age"]);
		}
	}
}