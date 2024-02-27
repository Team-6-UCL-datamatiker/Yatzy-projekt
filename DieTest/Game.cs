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
        private int genstart;
        private GameHelper gH = new GameHelper();
        private Turn t = new Turn();
        private ScoreCard sC = new ScoreCard();


        public void Execute()
        {
            //Intro
            Console.WriteLine("Velkommen til Yatzy.");
            Console.WriteLine("\nIndtast antallet af spillere (2-5).\n");
            int iPlayers = gH.NoOfPlayers(Console.ReadLine());
            Player[] playersA = gH.CreatePlayers(iPlayers);

            //Løkke der starter turen og genstarter løkken, hvis spilleren vil spille igen:
            while (genstart < 15)
            {
                t.StartTurn(playersA, sC);
                Console.WriteLine("Tryk på Enter for at spille igen, eller tast \"q\" for at afslutte.\n");
                sC.PrintScoreCard(playersA);
                genstart++;

            }
        }

    }
}
