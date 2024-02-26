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

        public void lockDie(int index)
        {
            if (index >= 0 && index < dice.Length)
            {
                dice[index].freeze();
            }
        }

        public void unlockDie(int index)
        {
            if (index >= 0 && index < dice.Length)
            {
                dice[index].unlock();
            }
        }

        public void unlockAllDice()
        {
            foreach (Die d in dice)
            {
                d.unlock();
            }
        }

        public void printResults()
        {
            foreach (Die d in dice)
            {
                Console.WriteLine(d.getValue());
            }
        }
    }
}
