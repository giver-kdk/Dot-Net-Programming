using System;

namespace StructEnumPartialClass
{
	public partial class Program
	{
		public struct Employee                  // Struct
		{
			public string name;
			private string address;
			public Employee()
			{
				name = "No Name";
				address = "No Address";
			}
			public Employee(string name, string address)
			{
				this.name = name;
				this.address = address;
			}
			public void ShowInfo()
			{
				Console.WriteLine("Employee Name: {0}", name);
				Console.WriteLine("Employee Address: {0}", address);
			}
		}
	}
}