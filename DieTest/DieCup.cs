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
        public void PrintValue(int i)
        {
            Console.Clear();
            Console.WriteLine((i+1) + ". Rul\n");
            Console.WriteLine(d1.PrintFrozen() + "Terning 1: " + d1.GetValue());
            Console.WriteLine(d2.PrintFrozen() + "Terning 2: " + d2.GetValue());
            Console.WriteLine(d3.PrintFrozen() + "Terning 3: " + d3.GetValue());
            Console.WriteLine(d4.PrintFrozen() + "Terning 4: " + d4.GetValue());
            Console.WriteLine(d5.PrintFrozen() + "Terning 5: " + d5.GetValue());
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
                        d1.ChangeIsFrozen();
                        break;
                    case '2':
                        d2.ChangeIsFrozen();
                        break;
                    case '3':
                        d3.ChangeIsFrozen();
                        break;
                    case '4':
                        d4.ChangeIsFrozen();
                        break;
                    case '5':
                        d5.ChangeIsFrozen();
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
            d1.Freeze();
            d2.Freeze();
            d3.Freeze();
            d4.Freeze();
            d5.Freeze();
        }
    }
}
