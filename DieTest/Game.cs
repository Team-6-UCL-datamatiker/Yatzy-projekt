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
            Console.WriteLine("\nIndtast antallet af spillere (1-5).\n");
            int iPlayers = gH.NoOfPlayers(Console.ReadLine());
            Player[] playersA = gH.CreatePlayers(iPlayers);

            //Løkke der starter turen og genstarter løkken, hvis spilleren vil spille igen:
            while (genstart < 14)
            {
                Console.WriteLine("Get ready for round {0}\n", genstart + 1);
                Console.ReadLine();
                t.StartTurn(playersA, sC);
                sC.PrintScoreCard(playersA);
                genstart++;

            }

            foreach (Player p in playersA)
            {
                int i = 0;
                if (p.TotalScore > i)
                {
                    i = p.TotalScore;
                    Console.Clear();
                    sC.PrintScoreCard(playersA);
                    Console.WriteLine(p.Name + " VINDER MED " + i + " POINT!");
                    Console.SetCursorPosition(2, 0);
                    for (int j = 0; j < 100; j++)
                    {
                        Thread.Sleep(750);
                        Console.WriteLine(new string(' ', j * 2) + "HAHAHA TABERE!");
                    }
                }
            }
            Console.ReadLine();
        }

    }
}
