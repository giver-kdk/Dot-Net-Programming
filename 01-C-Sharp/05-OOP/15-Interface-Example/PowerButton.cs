using System;

namespace ElectronicSystem
{
	public class PowerButton : ICommand
	{
		
		// Instance of this PowerButton can turn On/Off any kind of Electronic Device. So, Flexible
		public IElectronicDevice Device { get; set; }
		// Setting device is equivalent to connecting with the device
		public PowerButton(IElectronicDevice d)
		{
			Device = d;
		}
		public void Execute()
		{
			// Since, the 'Device' is 'IELectroniDevice'. So, it must have 'On()' method implementation
			Device.On();
		}
		public void Undo()
		{
			// Since, the 'Device' is 'IELectroniDevice'. So, it must have 'Off()' method implementation
			Device.Off();
		}
	}
}
