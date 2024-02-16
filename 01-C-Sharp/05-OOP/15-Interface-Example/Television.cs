using System;

namespace ElectronicSystem
{
	// Simply implement the 'IElectronicDevice' with extra custom features
	public class Television : IElectronicDevice
	{
		public int Volume { get; set; } = 0;	

		public Television() { }
		public Television(int v)
		{
			Volume = v;
		}
		public void On()
		{
			Console.WriteLine("TV is now On");
		}
		public void Off()
		{
			Console.WriteLine("TV is now Off");
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