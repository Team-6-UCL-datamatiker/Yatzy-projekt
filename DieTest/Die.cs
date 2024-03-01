using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Die
    {
        // Feltvariable:
        private Random r = new Random();

        // Properties:
        public int Eyes { get; set; }
        public bool IsFrozen { get; set; }

        // Metoder:
        public void Roll()
        {
            if (IsFrozen == false)
            {
                Eyes = r.Next(1, 7);
            }
        }

        //Toggle freeze
        public void SwitchIsFrozen()
        {
            if (IsFrozen == true)
            {
                IsFrozen = false;
            }
            else
            {
                IsFrozen = true;
            }
        }

        //Frozen die is indicated with an X
        public string PrintIsFrozen()
        {
            if (IsFrozen == true)
            {
                return "[X] ";
            }
            else
            {
                return "[ ] ";
            }
        }

    }
}
