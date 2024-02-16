using System;

namespace ElectronicSystem
{
	// Interface for all controllers defining compulsary commands
	public interface ICommand
	{
		public void Execute();
		public void Undo();
	}
}
