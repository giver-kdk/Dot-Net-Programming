using System;

namespace EventApp
{
	public delegate void MyEventHandler(string str);
	public class Publisher
	{
		public event MyEventHandler OnValueAssign;    
		public string name;
		public void SetName(string value)
		{
			name = value;
			OnValueAssign?.Invoke(name);                
		}
	}
	public class Subscriber
	{
		public void ShowUpdate(string str)            
		{
			Console.WriteLine("You updated value as: " + str);
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Publisher p1 = new Publisher();
			Subscriber s1 = new Subscriber();
			p1.OnValueAssign += s1.ShowUpdate;

			Console.Write("Enter a name: ");
			string input = Console.ReadLine();
			p1.SetName(input);
			Console.WriteLine("Lab No: 9e");
			Console.WriteLine("Name: Giver Khadka");
			Console.WriteLine("Roll No.: 05");
		}
	}
}
