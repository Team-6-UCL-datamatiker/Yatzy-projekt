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
            string s = "";

            // Starter turen:
            Console.WriteLine("Tryk på Enter for at rafle.\n");
            Console.ReadLine();

            // Løkke der giver spilleren 3 rul med raflebægeret:
            while (i < 3)
            {
                // Rafle Version 1
                // MEGET VIGTIG IMMERSION! ("Rafle-animation")
                for (int j = 0; j < 20; j++)
                {
                    dc1.Roll();
                    dc1.PrintEyes(i);
                    Console.WriteLine("\nRafle rafle rafle...\n");
                    Thread.Sleep(75);
                }

                dc1.Roll();
                dc1.PrintEyes(i);
                //Ændrer konsolteksten efter de første 2 rul, da man ikke kan låse (op) eller rafle efter sidste rul:
                if (i < 2)
                {
                    //While-løkken gør, at man skal bekræfte sit valg af låste terninger, før spillet fortsætter:
                    //Spillet fortsætter ikke, så længe der indtastes noget i terminalen (!= ""):
                    //Derfor sættes strengen s til ikke at være tom (arbitrært sat til "a") før hver løkke:
                    //Spillet fortsætter når der trykkes Enter uden input:
                    s = "a";
                    Console.WriteLine("\nIndtast numrene på de terninger, du vil låse (op), eller tryk på Enter for at rafle.\n");
                    while (s != "")
                    {
                        s = Console.ReadLine();
                        dc1.FreezeMultipleDie(s);
                        dc1.PrintEyes(i);
                        Console.WriteLine("\nIndtast numrene på de terninger, du vil låse (op), eller tryk på Enter for at rafle.\n");
                    }
                }
                else
                {
                    dc1.FreezeAllDie();
                    dc1.PrintEyes(i);
                    Console.WriteLine("\nKlasse raflet! Tryk på Enter for at afslutte din tur.\n");
                    Console.ReadLine();
                    Console.Clear();
                }
                i++;
            }
        }
    }
}
