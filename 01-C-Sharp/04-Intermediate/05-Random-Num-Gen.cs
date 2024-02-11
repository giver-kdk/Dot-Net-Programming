using System;

namespace RandomNumGen
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Random rand = new Random();
			// Generate random value between certain range
			int randomNum = rand.Next(1, 10);
			Console.WriteLine(randomNum);
			// For Wait at program end
			Console.ReadLine();
		}
	}
}