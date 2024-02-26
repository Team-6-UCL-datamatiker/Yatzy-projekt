using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class DieCup
    {
        // Feltvariable:
        private Dice[] dieA = new Dice[5] { new Dice(), new Dice(), new Dice(), new Dice(), new Dice() };

        // Metoder:
        // Ruller alle terninger i arrayet:
        public void Roll()
        {
            foreach (Dice d in dieA)
            {
                d.Roll();
            }

        }

        // Printer oversigt over alle terninger i konsollen:
        public void PrintEyes(int i)
        {
            Console.Clear();
            Console.WriteLine((i + 1) + ". Rul\n");
            foreach (Dice d in dieA)
            {
                Console.WriteLine(d.PrintIsFrozen() + "Terning " + (Array.IndexOf(dieA, d) + 1) + ": " + d.Eyes);
            }
        }

        // Tager en streng som parameter og låser terningerne der svarer til de indtastede cifre:
        public void FreezeMultipleDie(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                if (s.Contains((i + 1).ToString()))
                {
                    dieA[i].SwitchIsFrozen();
                }
            }
        }

        // Låser alle terninger (bruges efter tredje rul):
        public void FreezeAllDie()
        {
            foreach (Dice d in dieA)
            {
                d.IsFrozen = true;
            }
        }
    }
}
