using System;

namespace ElectronicSystem
{
	// Simply implement the 'IElectronicDevice' with extra custom features
	public class Projector : IElectronicDevice
	{
		public int Volume { get; set; } = 0;

		public Projector() { }
		public Projector(int v)
		{
			Volume = v;
		}
		public void On()
		{
			Console.WriteLine("Projector is now On");
		}
		public void Off()
		{
			Console.WriteLine("Projector is now Off");
		}
		public void VolumeUp()
		{
			if (Volume < 100) Volume++;
			Console.WriteLine("Volume Increased: {0}", Volume);
		}
		public void VolumeDown()
		{
			if (Volume > 0) Volume--;
			Console.WriteLine("Volume Decreased: {0}", Volume);
		}
	}
}