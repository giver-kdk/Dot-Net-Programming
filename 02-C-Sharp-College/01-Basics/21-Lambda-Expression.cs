using System;

namespace LambaApp
{
	public delegate string GreetDelegate(string name);
	public class Program
	{
		// This method only has one task of returning the greeting message
		public string SayHello(string name)
		{
			return $"Hello {name}";
		}
		public static void Main(string[] args)
		{
			Program obj = new Program();
			GreetDelegate gd = obj.SayHello;
			string msg = gd("Giver");
			Console.WriteLine(msg);


			// Anonymous Method is used with the help of Delegate. This function has no name 
			GreetDelegate gd2 = delegate (string name)
			{
				return $"Hello {name}";
			};
			string msg2 = gd2("Ram");
			Console.WriteLine(msg2);

			// Lambda Expression without name.
			// No need to specify parameter type as it's already specified by delegate signature
			// This is 'Statement Lambda'
			GreetDelegate gd3 = (name) =>
			{
				return $"Hello {name}";
			};
			string msg3 = gd3("Shyam");
			Console.WriteLine(msg3);

			// This is 'Expression Lambda'. Here, no need to write 'return' for expression lambda
			GreetDelegate gd4 = (name) => $"Hello {name}";
			string msg4 = gd4("Hari");
			Console.WriteLine(msg4);
		}
	}
}