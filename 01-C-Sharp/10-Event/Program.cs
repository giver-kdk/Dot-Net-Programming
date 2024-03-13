using System;
// Event in C# is same as event in JS
// It follows Publisher-Subscriber model
// Publisher is the class/object that declares and emits the event
// Subscriber is the class/object that subscribes to the event and handles it
// One publisher can have multiple subscribers and vice versa

namespace EventApp
{
	public delegate void MyEventHandler(string str);
	public class Publisher
	{
		public event MyEventHandler OnValueAssign;      // Declaring Event in Publisher Class
		public string name;
		public void SetName(string value)
		{
			name = value;
			OnValueAssign?.Invoke(name);                // Emit Event only if subscriber exists
			//if (OnValueAssign != null) OnValueAssign(name);			// Same as above line
		}
	}
	public class Subscriber
	{
		// Runs when subscribed event is emitted/raised 
		public void ShowUpdate(string str)              // Event Handler Method in Subscriber Class
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
			// Subscribing/Adding event handler to the event
			// Here, 's1.ShowUpdate' is not a delegate but is being allowed to be added to a delegate type event
			// Behind the scene, compiler automatically converts the 's1.ShowUpdate' method to delegate type
			p1.OnValueAssign += s1.ShowUpdate;

			Console.Write("Enter a name: ");
			string input = Console.ReadLine();
			p1.SetName(input);                  // This method wil cause the event to emit
		}
	}
}
