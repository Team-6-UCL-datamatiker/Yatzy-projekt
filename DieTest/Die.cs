using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Die
    {
        private int value;
        private bool isLocked;

        public void roll()
        {
            if (this.isLocked == false)
            {
                Random r = new Random();
                int randomValue = r.Next(1, 7);
                this.value = randomValue;
            }

        }

        public int getValue()
        {
            return this.value;
        }

        public void freeze()
        {
            this.isLocked = true;
        }

        public void unlock()
        {
            this.isLocked = false;
        }
    }
}
