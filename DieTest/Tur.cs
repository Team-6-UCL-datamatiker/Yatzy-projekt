using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Tur
    {
        // Feltvariable:

        // Metoder:
        public void StartTur()
        {
            DieCup dc1 = new DieCup();
            int i = 0;
            Console.WriteLine("Tryk på Enter for at rafle.");
            Console.ReadLine();
            while (i < 3)
            {
                Console.Clear();
                dc1.PrintValue();
                dc1.Roll();
                Thread.Sleep(1000);
                Console.WriteLine("\nRafle rafle...");
                Thread.Sleep(1500);
                Console.Clear();
                dc1.PrintValue();
                if (i < 2)
                {
                    Console.WriteLine("\nIndtast numrene på de terninger, du vil låse (op), og tryk enter for at rafle.");
                    dc1.FreezeMultipleDie(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("\nKlasse raflet! Tryk Enter for at fortsætte.");
                    Console.ReadLine();
                    Console.Clear();
                }
                i++;
            }
        }
    }
}
