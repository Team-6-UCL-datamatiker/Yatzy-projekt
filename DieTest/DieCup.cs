using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class DieCup
    {
        private Die[] dice = new Die[5];

        private Die die1 = new Die();
        private Die die2 = new Die();
        private Die die3 = new Die();
        private Die die4 = new Die();
        private Die die5 = new Die();

        public DieCup()
        {
            dice[0] = die1;
            dice[1] = die2;
            dice[2] = die3;
            dice[3] = die4;
            dice[4] = die5;
        }

        public void roll()
        {
            foreach (Die d in dice)
            {
                d.roll();
            }
        }

        public void freezeMultipleDice(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                if (s.Contains((i + 1).ToString()))
                {
                    dice[i].switchIsFrozen();
                }
            }
        }
        public void freezeAllDice()
        {
            foreach (Die d in dice)
            {
                d.IsFrozen = true;
            }
        }

        public void unfreezeAllDice()
        {
            foreach (Die d in dice) 
            {
                d.IsFrozen = false;
            }
        }

        public void printEyes(int i)
        {
            Console.Clear();
            Console.WriteLine((2 - i) + ". Rerolls left\n");
            foreach (Die d in dice)
            {
                Console.WriteLine(d.printIsFrozen() + "Terning " + (Array.IndexOf(dice, d) + 1) + ": " + d.Eyes);
            }
        }

    }
}
