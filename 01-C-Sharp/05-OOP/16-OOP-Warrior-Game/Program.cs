using System;

namespace WarriorGame
{
	public class Program
	{
		public static void Main(string[] args) 
		{
			Warrior thor = new Warrior("Thor", 100, 75, 25);
			//Warrior loki = new Warrior("Loki", 100, 75, 25);
			MagicalWarrior loki = new MagicalWarrior("Loki", 75, 60, 25, 40);

			Battle.StartFight(thor, loki);
		}
	}
}