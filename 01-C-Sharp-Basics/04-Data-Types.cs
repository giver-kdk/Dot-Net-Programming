using System;

namespace DataTypes
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Explicit Decalaration: Declare data type manually 
			int n1 = 2;						// Interger (Signed)	
			long n2 = 4;					// Long Interger (Signed)	
			short n3 = 6;					// Shourt Interger (Signed)	
			uint n4 = 2;					// Unsigned Integer (Only +ve value)
			ulong n5 = 4;					// Unsigned Long Integer (Only +ve value)
			ushort n6 = 6;					// Unsigned Short Integer (Only +ve value)

			//  Remember to use 'F', 'D' and 'M' suffix for float, double and decimal
			float a = 3.4f;					// Float stores 6+ digit precision
			double b = 4.560956d;			// Double stores 14+ digit precision
			decimal c = 5.4398534543m;		// Decimal stores 28+ digit precision

			string name = "Giver";			// String stores string
			char ch = 'a';					// Char stores single character

			bool isValid = true;			// Boolean is 'true' or 'false' 
			byte value1 = 0;				// Byte stores value between 0 to 255
			sbyte value2 = -120;			// SByte(Signed Byte) stores value between -128 to 127

			// Implicit Decalaration: Data type automatically set by compiler 
			var address = "Kathmandu";		// String
			var age = 20;					// Integer
			var isCorrect = true;			// Boolean

			// Accessing maximum and minumum value stored by particular data type
			Console.WriteLine("Max int: {0}", int.MaxValue);
			Console.WriteLine("Min int: {0}", int.MinValue);
			Console.WriteLine("Max long: {0}", long.MaxValue);
			Console.WriteLine("Min long: {0}", long.MinValue);
			Console.WriteLine("Max short: {0}", short.MaxValue);
			Console.WriteLine("Min short: {0}", short.MinValue);
			Console.WriteLine("Max float: {0}", float.MaxValue);
			Console.WriteLine("Min float: {0}", float.MinValue);
			Console.WriteLine("Max double: {0}", double.MaxValue);
			Console.WriteLine("Min double: {0}", double.MinValue);
			Console.WriteLine("Max decimal: {0}", decimal.MaxValue);
			Console.WriteLine("Min decimal: {0}", decimal.MinValue);
			Console.WriteLine("Min byte: {0}",  byte.MaxValue);
			Console.WriteLine("Min byte: {0}", byte.MinValue);
		}
	}
}