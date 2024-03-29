﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillBillLibrary
{
	public class Combat
	{
		public static void DoAttack(Character attacker, Character defender)
		{
			//get a random number from 1-100
			//This random number is similating a dice roll in the game

			Random rand = new Random();
			int diceRoll = rand.Next(1, 101);
			System.Threading.Thread.Sleep(30);

			if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
			{
				//when the attacker landed a successfull attack on the defender 
				int damageDealt = attacker.CalcDamage();

				//assign the damage
				defender.Life -= damageDealt;


				//write result to the screen
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);
				Console.ResetColor();

			}
			else
			{

				Console.WriteLine("{0} missed!", attacker.Name);

			}
		}

		public static void DoBattle(Player player, Opponent opponent)
		{
			//player gets to attack first
			DoAttack(player, opponent);

			//opponnent attacks second if still alive
			if (opponent.Life > 0)
			{
				DoAttack(opponent, player);
			}
		}
	}
}
