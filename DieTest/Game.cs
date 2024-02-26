using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Game
    {
        // Feltvariable:
        private string genstart = "";
        private string antalSpillere;
        private Turn t = new Turn();


        public void Execute()
        {
            //Velkomstbesked:
            Console.WriteLine("Velkommen til Raflebæger Simulator. Indtast antallet af spillere.\n");
            antalSpillere = Console.ReadLine();
            Console.Clear();

            //Løkke der starter turen og genstarter løkken, hvis spilleren vil spille igen:
            while (genstart != "q")
            {
                t.StartTur();
                Console.WriteLine("Tryk på Enter for at spille igen, eller tast \"q\" for at afslutte.\n");
                genstart = Console.ReadLine();
                Console.Clear();
            }
        }

    }
}
