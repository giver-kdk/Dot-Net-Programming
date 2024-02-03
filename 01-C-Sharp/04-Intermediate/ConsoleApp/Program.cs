using System;
using System.Text;

namespace StrigBuilder
{
	public class Program
	{
		static void Main(string[] args)
		{
			// 'StringBuilder' is a class
			StringBuilder sb = new StringBuilder("Hello.");
			Console.WriteLine(sb.ToString());
		}
	}
}