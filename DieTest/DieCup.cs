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
        private Die[] dA = new Die[5] { new Die(), new Die(), new Die(), new Die(), new Die() };

        // Metoder:
        // Ruller alle terninger i arrayet:
        public void Roll()
        {
            foreach (Die d in dA)
            {
                d.Roll();
            }

        }

        // Printer oversigt over alle terninger i konsollen:
        public void PrintEyes(int i)
        {
            Console.Clear();
            Console.WriteLine((i + 1) + ". Rul\n");
            foreach (Die d in dA)
            {
                Console.WriteLine(d.PrintIsFrozen() + "Terning " + (Array.IndexOf(dA, d) + 1) + ": " + d.Eyes);
            }
        }

        // Tager en streng som parameter og låser terningerne der svarer til de indtastede cifre:
        public void FreezeMultipleDie(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                if (s.Contains((i + 1).ToString()))
                {
                    dA[i].SwitchIsFrozen();
                }
            }
        }

        // Låser alle terninger (bruges efter tredje rul):
        public void FreezeAllDie()
        {
            foreach (Die d in dA)
            {
                d.IsFrozen = true;
            }
        }
    }
}
