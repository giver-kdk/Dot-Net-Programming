using System;

namespace MethodHiding
{
	public class Car : Vehicle
	{
		public int Wheels { get; set; }

		public Car() { }
		public Car(string n, int w) : base(n)
		{
			Wheels = w;
		}
		// Overridden method still has relation with base method
		public override void Greet()
		{
			Console.WriteLine("Hello Car Driver!");
		}
		// Now, this method is a new method and has no relation with 'ShowInfo()' of base class
		public new void ShowInfo()
		{
			Console.WriteLine("Car Name is: {0}", Name);
			Console.WriteLine("Wheels Number: {0}", Wheels);
		}
		// If we simply write same method without 'new', then also it hides the method
		// We use 'new' just to explicitly indicate we want to hide method and compiler won't show warning
		//public void ShowInfo()
		//{
		//	Console.WriteLine("Car Name is: {0}", Name);
		//	Console.WriteLine("Wheels Number: {0}", Wheels);
		//}
	}
}