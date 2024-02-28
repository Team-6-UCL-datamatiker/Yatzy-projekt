using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class DieCup
    {
        // Feltvariable/Properties:
        //
        private Die[] dieA = new Die[5] { new Die(), new Die(), new Die(), new Die(), new Die() };
        public Die[] DieA { get { return dieA; } }

        // Metoder:
        //
        public void Roll()
        {
            foreach (Die d in dieA)
            {
                d.Roll();
            }

        }
        public void PrintEyes(int i)
        {
            Console.WriteLine((i + 1) + ". Rul\n");
            foreach (Die d in dieA)
            {
                Console.WriteLine(d.PrintIsFrozen() + "Terning " + (Array.IndexOf(dieA, d) + 1) + ": " + d.Eyes);
            }
        }
        public void FreezeMultipleDice(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                if (s.Contains((i + 1).ToString()))
                {
                    dieA[i].SwitchIsFrozen();
                }
            }
        }
        public void FreezeAllDice()
        {
            foreach (Die d in dieA)
            {
                d.IsFrozen = true;
            }
        }
    }
}
