using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ændringer i Jeppes kode: Lavet det konsistent med frozen/freeze navnene (i stedet for lock), ændret metodenavnene til uppercase og fjernet en overflødig int fra if-statement i Roll().
// Ændret value-navnet til eyes for at gøre navnet mere eksplicit (value er meget generisk).
// Derudover lavet eyes-variablen om til en property "Eyes" (ligesom Jesper havde gjort), hvilket gør GetValue()/GetEyes() overflødig. Selve variablen (som nu hedder _eyes) er stadig privat selvom propertyen er public.
// Også lavet isFrozen om til en property, hvilket gjorde Freeze() og UnFreeze() overflødige.
// Tilføjet SwitchIsFrozen() og PrintFrozen().
// Flyttet Random r op som feltvariabel, da der ikke er nogen grund til at den laver en ny i hvert Roll().
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

        // Metode der sætter isFrozen til det modsatte af, hvad den var:
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

        // Metode der bruges til i konsollen at vise om en terning er låst eller ej:
        public string PrintFrozen()
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
