using System;

namespace ElectronicSystem
{
	// Interface for all electronic devices defining compulsary features
	public interface IElectronicDevice
	{
		public void On();
		public void Off();
		public void VolumeUp();
		public void VolumeDown();
	}
}