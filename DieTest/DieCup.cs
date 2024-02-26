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
        private Die d1 = new Die();
        private Die d2 = new Die();
        private Die d3 = new Die();
        private Die d4 = new Die();
        private Die d5 = new Die();
        // Metoder:
        public void Roll()
        {
            d1.Roll();
            d2.Roll();
            d3.Roll();
            d4.Roll();
            d5.Roll();
        }

        // Tager den int, der styrer hvor mange rul man har, som parameter for at printe om det er 1., 2. eller 3. rul (første WriteLine):
        // Printer låsestatus + nr. terning + værdien af seneste rul for hver terning:
        // Clearer terminalen før hvert print, så det kun står der én gang og altid øverst:
        public void PrintEyes(int i)
        {
            Console.Clear();
            Console.WriteLine((i+1) + ". Rul\n");
            Console.WriteLine(d1.PrintIsFrozen() + "Terning 1: " + d1.Eyes);
            Console.WriteLine(d2.PrintIsFrozen() + "Terning 2: " + d2.Eyes);
            Console.WriteLine(d3.PrintIsFrozen() + "Terning 3: " + d3.Eyes);
            Console.WriteLine(d4.PrintIsFrozen() + "Terning 4: " + d4.Eyes);
            Console.WriteLine(d5.PrintIsFrozen() + "Terning 5: " + d5.Eyes);
        }

        // Tager en streng som parameter for at tjekke hvilke cifre, der er indtastet, når spilleren vil låse terninger, og låser de tilsvarende terninger:
        public void FreezeMultipleDie(string s)
        {
            // Lokale variable for metoden:
            int length = s.Length;
            int i = 0;

            // While-løkke der gennemgår alle chars i strengen og ignorerer alt andet end tallene 1-5:
            while (i < length)
            {
                char ch1 = s[i];
                switch (ch1)
                {
                    case '1':
                        d1.SwitchIsFrozen();
                        break;
                    case '2':
                        d2.SwitchIsFrozen();
                        break;
                    case '3':
                        d3.SwitchIsFrozen();
                        break;
                    case '4':
                        d4.SwitchIsFrozen();
                        break;
                    case '5':
                        d5.SwitchIsFrozen();
                        break;
                    default:
                        break;
                }
                i++;
            }
        }

        // Låser alle terninger (bruges efter tredje rul):
        public void FreezeAllDie()
        {
            d1.IsFrozen = true;
            d2.IsFrozen = true;
            d3.IsFrozen = true;
            d4.IsFrozen = true;
            d5.IsFrozen = true;
        }
    }
}
