using System;

namespace DelegateApp
{
	public class Program
	{
		public delegate void MyDelegate(string msg);
		public static void MethodA(string message)
		{
			Console.WriteLine(message);
		}
		public static void Main(string[] args)
		{
			MyDelegate md1 = MethodA;
			md1("Hello World");
		}
	}
}