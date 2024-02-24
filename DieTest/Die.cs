using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ændringer i Jeppes kode: Lavet det konsistent med frozen/freeze navnene (i stedet for lock), ændret metodenavnene til uppercase og fjernet en overflødig int fra if-statement i Roll().
// Tilføjet ChangeIsFrozen() og PrintFrozen().
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

        // Metode der sætter isFrozen til det modsatte af, hvad den var:
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

        // Metode der bruges i konsollen til at vise om en terning er låst eller ej:
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
