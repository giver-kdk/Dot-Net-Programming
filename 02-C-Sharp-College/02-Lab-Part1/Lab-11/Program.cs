using System;

namespace GenericsExampleApp
{
	public class MyClass<T>                        // Generic Class
	{
		public T? value;                            // Generic Field
		public void Sum(T x, T y)                   // Generic Method
		{
			dynamic a = x;
			dynamic b = y;
			Console.WriteLine($"Sum is: {a + b}");
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			MyClass<int> m1 = new MyClass<int>();       // The object is of type 'int' now
			m1.Sum(5, 6);
			m1.value = 5;
			Console.WriteLine(m1.value);

			MyClass<string> m3 = new MyClass<string>();   // The object is of type 'float' now
			m3.Sum("Hello", "World");
			m3.value = "Greeting";
			Console.WriteLine(m3.value);
			Console.WriteLine("Lab No: 11");
			Console.WriteLine("Name: Giver Khadka");
			Console.WriteLine("Roll No.: 05");
		}
	}
}