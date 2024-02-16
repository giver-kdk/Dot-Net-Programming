using System;

namespace ElectronicSystem
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// If 'isTV' is 'false', we'll get 'Projector' device
			bool isTV = true;			
			// We can implicitely convert 'Class' to 'Interface'
			IElectronicDevice TV = Remote.GetRemote(isTV);						// Pick up TV Remote
			// But, should explicitely convert 'Interface' to 'Class'
			// Because 'Class' might have extra field to be initialized
			//Television TV = (Television) TVRemote.GetRemote();

			PowerButton PowBtn = new PowerButton(TV);							// Power Button connected to TV

			PowBtn.Execute();													// Press Power Button
			PowBtn.Undo();
			PowBtn.Execute();

			//Console.WriteLine(TV.Volume);		// Can't access 'Television' class fields
			// We can only access 'IElectronicDevice's methods with 'Television's implementation
			TV.VolumeUp();
			TV.VolumeDown();
		}
	}
}