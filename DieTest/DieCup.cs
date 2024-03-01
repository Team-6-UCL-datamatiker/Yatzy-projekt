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
        private Die[] dieArray = new Die[5] { new Die(), new Die(), new Die(), new Die(), new Die() };
        public Die[] DieArray { get { return dieArray; } }

        // Metoder:
        public void Roll()
        {
            foreach (Die d in dieArray)
            {
                d.Roll();
            }

        }
        public void FreezeMultipleDice(string specifiedDice)
        {
            for (int i = 0; i < 5; i++)
            {
                if (specifiedDice.Contains((i + 1).ToString()))
                {
                    dieArray[i].SwitchIsFrozen();
                }
            }
        }
        public void FreezeAllDice()
        {
            foreach (Die die in dieArray)
            {
                die.IsFrozen = true;
            }
        }
        public void UnFreezeAllDice()
        {
            foreach (Die die in dieArray)
            {
                die.IsFrozen = false;
            }
        }

        public int[] GetDiceValues()
        {
            int[] dieArrayEyes = new int[5];
            for (int i = 0; i < 5; i++)
            {
                dieArrayEyes[i] = DieArray[i].Eyes;
            }
            return dieArrayEyes;
        }
    }
}
