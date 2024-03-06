using System;
// Exeption is a unexpected error occurred during runtime
// Technically, it is an Object in C# which is created on error
// If exception is not handled in C#, then program stops at the line of exceptions
// And runtime throws the exception
// Exceptions are derived from 'System.Exception' in C#
/*
    Bult-in System Exception Types:
    - IOException
    - DivideByZeroException
*/
// User Defined Exception: User can create custom exeption classes
namespace ExceptionHandlingApp
{
	public class Program
	{
		public static void CheckDivision(int a, int b)
		{
			try
			{
				if (b == 0)
				{
					throw new DivideByZeroException();
				}
				else
				{
					Console.WriteLine("Division is: " + a / b);
				}
			}
			catch (DivideByZeroException err)
			{
				Console.WriteLine(err.Message);
			}
			finally
			{
				Console.WriteLine("Division Completed!");
			}
		}

		public static void Main(string[] args)
		{
			int a = 5;
			int b = 0;
			//int b = 5;

			CheckDivision(a, b);
		}
	}
}