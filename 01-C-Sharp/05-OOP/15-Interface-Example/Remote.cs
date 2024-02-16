using System;

namespace ElectronicSystem
{
	public class Remote
	{
		// We are being generic in terms of return type for abstraction.
		// The function can now return any object that implements 'IElectronicDevice'
		public static IElectronicDevice GetRemote(bool isTV)
		{
			if (isTV) return new Television(25);
			else return new Projector(50);
		}
	}
}
