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
            // Lokale variable for metoden:
            DieCup dc1 = new DieCup();
            int i = 0;

            // Starter turen:
            Console.WriteLine("Tryk på Enter for at rafle.");
            Console.ReadLine();

            // Løkke der giver spilleren 3 rul med raflebægeret:
            // Kalder dc1.Printvalue() efter hver Console.Clear() i løkken for at holde oversigt over terninger konstant synlig i konsollen.
            while (i < 3)
            {
                // MEGET VIGTIG IMMERSION!
                for (int j = 0; j < 20; j++ )
                {
                    dc1.Roll();
                    Console.Clear();
                    dc1.PrintValue();
                    Console.WriteLine("\nRafle rafle rafle...");
                    Thread.Sleep(75);
                }
                dc1.Roll();
                Console.Clear();
                dc1.PrintValue();
                //Ændrer konsolteksten efter de første 2 rul, da man ikke kan låse (op) eller rafle efter sidste rul:
                if (i < 2)
                {
                    Console.WriteLine("\nIndtast numrene på de terninger, du vil låse (op), og tryk på Enter for at rafle.");
                    dc1.FreezeMultipleDie(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("\nKlasse raflet! Tryk på Enter for at afslutte denne tur.");
                    Console.ReadLine();
                    Console.Clear();
                }
                i++;
            }
        }
    }
}
