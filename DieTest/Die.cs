using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lavet det konsistent med frozen/freeze navnene, ændret metodenavnene til uppercase og fjernet en overflødig int fra if-statement i roll()

namespace DieTest
{
    internal class Die
    {
        // Feltvariable:
        private int value;
        private bool isFrozen;

        // Metoder:
        public void Roll()
        {
            if (isFrozen == false)
            {
                Random r = new Random();
                value = r.Next(1, 7);
            }
        }

        public int GetValue()
        {
            return value;
        }

        public void Freeze()
        {
            isFrozen = true;
        }

        public void UnFreeze()
        {
            isFrozen = false;
        }

        public void ChangeIsFrozen()
        {
            if (isFrozen == true)
            {
                UnFreeze();
            }
            else
            {
                Freeze();
            }
        }

        public string PrintFrozen()
        {
            if (isFrozen == true)
            {
                return "[L] ";
            }
            else
            {
                return "[ ] ";
            }
        }
    }
}
