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
        private int d1Value = 0;
        private int d2Value = 0;
        private int d3Value = 0;
        private int d4Value = 0;
        private int d5Value = 0;


        // Metoder:
        public void Roll()
        {
            d1.Roll();
            d1Value = d1.GetValue();
            d2.Roll();
            d2Value = d2.GetValue();
            d3.Roll();
            d3Value = d3.GetValue();
            d4.Roll();
            d4Value = d4.GetValue();
            d5.Roll();
            d5Value = d5.GetValue();
        }

        public void PrintValue()
        {
            Console.WriteLine(d1.PrintFrozen() + "1: " + d1Value);
            Console.WriteLine(d2.PrintFrozen() + "2: " + d2Value);
            Console.WriteLine(d3.PrintFrozen() + "3: " + d3Value);
            Console.WriteLine(d4.PrintFrozen() + "4: " + d4Value);
            Console.WriteLine(d5.PrintFrozen() + "5: " + d5Value);
        }

        public void FreezeMultipleDie(string s)
        {
            int length = s.Length;
            int i = 0;

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
