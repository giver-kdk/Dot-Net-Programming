using System;

namespace WarriorGame
{
	public class Battle
	{
		public static bool GetAttackResult(Warrior Attacker, Warrior Victim)	
		{ 
			double damage = Attacker.Attack();
			double block = Victim.Block();
			double netDamage = damage - block;

			if (netDamage > 0) 
			{
				Victim.Health -= netDamage;
			}
			else
			{
				netDamage = 0;
			}
			Console.WriteLine("{0} did {1} damage to {2}", Attacker.Name, netDamage, Victim.Name);
			Console.WriteLine("{0} health is {1}", Victim.Name, Victim.Health);
			// 'true' means victim is alive
			if (Victim.Health > 0)
			{
				Console.WriteLine();
				return true;
			}
			else
			{
				Console.WriteLine("{0} died and {1} won\n", Victim.Name, Attacker.Name);
				return false;
			}
		}

		public static void StartFight(Warrior W1, Warrior W2)
		{
			while(true)
			{
				bool bothAlive = GetAttackResult(W1, W2) && GetAttackResult(W2, W1);
				if (bothAlive) continue;
				else break;
			}
		}
	}
}
