using System;

namespace WarriorGame
{
	public class Warrior
	{
		public string Name { get; set; }
		public double Health{ get; set; }			
		public double AttackMax { get; set; }	// Maximum damage capacity
		public double BlockMax { get; set; }	// Maximum defence capacity
		public Random rnd = new Random();

		public Warrior(string n, double h, double a, double b) 
		{
			Name = n;
			Health = h;
			AttackMax = a;
			BlockMax = b;
		}
		public double Attack()
		{
			return rnd.Next(1, (int) AttackMax);
		}
		public virtual double Block()
		{
			return rnd.Next(1, (int)BlockMax);
		}
	}
}
