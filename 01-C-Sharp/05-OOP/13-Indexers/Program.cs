using System;

namespace Indexer
{
	public class Program
	{
		public static void Main(string[] args) 
		{
			Students s1 = new Students();
			// Set object's array member as if object is the array itself
			s1[0] = "Ram";
			s1[1] = "Shyam";
			s1[2] = "Hari";
			s1[3] = "Gopal";
			s1[4] = "Hari";             // 'Hari' already exists. So, this becomes 'null'

			// Set students age
			s1[0, true] = 19;
			s1[1, true] = 21;
			s1[2, true] = 20;
			s1[3, true] = 22;
			s1[4, true] = 18;

			// Set students roll number
			s1[0, false] = 19;
			s1[2, false] = 20;
			s1[1, false] = 21;
			s1[4, false] = 18;
			s1[3, false] = 22;

			// Get object's array members
			Console.WriteLine("Students Names: ");	
			foreach(string name in s1.names)
			{
				Console.WriteLine(name);	
			}

			Console.WriteLine("Students Age: ");	
			foreach(int age in s1.ages)
			{
				Console.WriteLine(age);	
			}

			Console.WriteLine("Students Roll: ");	
			foreach(int roll in s1.rolls)
			{
				Console.WriteLine(roll);	
			}
		}
	}
}