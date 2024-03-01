using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class DieCup
    {
        private Die[] dice = new Die[5];

        public DieCup()
        {
            //Make new dice and add to array
            for(int i = 0; i < dice.Length; i++) {
                dice[i] = new Die();
            }
        }

        //Rolls all dice in the diceCup
        public void Roll()
        {
            foreach (Die d in dice)
            {
                d.Roll();
            }
        }

        //Freezes the specified dice
        public void FreezeMultipleDice(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                if (s.Contains((i + 1).ToString()))
                {
                    dice[i].SwitchIsFrozen();
                }
            }
        }

        //Freeze all dice
        public void FreezeAllDice()
        {
            foreach (Die d in dice)
            {
                d.IsFrozen = true;
            }
        }

        //Unfreeze all dice
        public void UnfreezeAllDice()
        {
            foreach (Die d in dice)
            {
                d.IsFrozen = false;
            }
        }

        //Get the values of all dice in an array
        public int[] GetDiceValues()
        {
            int[] values = new int[5];
            for (int i = 0; i < 5; i++)
            {
                values[i] = dice[i].Eyes;
            }
            return values;
        }

        //Prints how many rerolls left, each die and if they are frozen or not
        public void PrintEyes(int i)
        {
            Console.Clear();
            Console.WriteLine((2 - i) + ". Rerolls left\n");
            foreach (Die d in dice)
            {
                Console.WriteLine(d.PrintIsFrozen() + "Terning " + (Array.IndexOf(dice, d) + 1) + ": " + d.Eyes);
            }
        }
    }
}
