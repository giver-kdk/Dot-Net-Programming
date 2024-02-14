using System;

namespace Indexer
{
	public class Students
	{
		public string?[] names = new string[5];
		public int[] ages = new int[5];
		public int[] rolls = new int[5];

		// This indexer returns the 'ith' string element of string array
		// Return type of the indexer becomes the 'value' type while assigning
		public string this[int i]
		{
			get
			{
				return names[i];
			}
			set
			{
				// Logic to set value without duplication
				if (!names.Contains(value))
				{
					names[i] = value;
				}
				else names[i] = null;
			}
		}
		// Indexer with multiple parameters
		public int this[int i, bool isAge]
		{
			// If 'isAge' is true, then provide age
			get
			{
				if (isAge) return ages[i];
				else return rolls[i];
			}
			set
			{
				if (isAge) ages[i] = value;
				else rolls[i] = value;
			}
		}
	}

}
