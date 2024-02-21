using System;

namespace WarriorGame
{
	public class MagicalWarrior : Warrior
	{
		public double TeleportChance{ get; set; }
		public MagicalWarrior(string n, double h, double a, double b, double t) : base(n, h, a, b)
		{
			TeleportChance = t;
		}
		public override double Block()
		{
			double randomDodge = rnd.Next(1, 100);
			if(randomDodge <= TeleportChance)
			{
				Console.WriteLine("{0} teleported!", Name);
				// Teleportation causes 0 damage. So, block is Infinite
				return double.PositiveInfinity;
			}
			else
			{
				// Run normal blocking if teleportation failed
				return base.Block();
			}
		}
	}
}
