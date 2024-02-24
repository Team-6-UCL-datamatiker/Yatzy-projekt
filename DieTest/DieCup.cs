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

        // Printer låsestatus + nr. terning + værdien af sidste rul:
        public void PrintValue()
        {
            Console.WriteLine(d1.PrintFrozen() + "1: " + d1.GetValue());
            Console.WriteLine(d2.PrintFrozen() + "2: " + d2.GetValue());
            Console.WriteLine(d3.PrintFrozen() + "3: " + d3.GetValue());
            Console.WriteLine(d4.PrintFrozen() + "4: " + d4.GetValue());
            Console.WriteLine(d5.PrintFrozen() + "5: " + d5.GetValue());
        }

        // Tjekker hvilke cifre, der er indtastet, når spilleren vil låse terninger, og låser de tilsvarende terninger:
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
    }
}
