using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class YatzyGame
    {
        private List<Player> players;
        private Player currentPlayer;
        private DieCup dieCup;
        private int currentRound;
        private Scoreboard scoreboard;

        public YatzyGame(int numberOfPlayers)
        {
            players = new List<Player>();
            dieCup = new DieCup();
            currentRound = 1;

            scoreboard = new Scoreboard();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player());
            }
            currentPlayer = players[0];
        }

        public void StartGame()
        {
            RegisterNames();
            for (int i = currentRound; i <= 14; currentRound++) //Round (14 total)
            {
                for (int j = 0; j < players.Count; j++) //Turn (1 for each player per round)
                {
                    PlayTurn();
                    ChangeTurn();
                }
            }
        }

        //sets name of each player 
        public void RegisterNames()
        {
            Console.Clear();
            for (int i = 1; i <= players.Count; i++)
            {
                while (true)
                {
                    Console.Write("Name of player" + i + ": ");
                    string name = Console.ReadLine();
                    if (name != null)
                    {
                        SetPlayerName(i - 1, name);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please type something!");
                    }
                }
            }
        }

        public void PlayTurn()
        {
            Console.Clear();
            dieCup.UnfreezeAllDice(); //starts with unfrozen dice on new turn
            String s = "";


            int rollCount = 0;
            while (rollCount < 3)
            {
               
                for (int j = 0; j < 20; j++)
                {
                    dieCup.Roll();
                    dieCup.PrintEyes(rollCount);
                    Console.WriteLine("\nRafle rafle rafle...\n");
                    Thread.Sleep(75);
                }
                Console.WriteLine(currentPlayer.GetName() + "'s turn");
                Console.WriteLine("Round: " + currentRound);

                if (rollCount < 2)
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
                        dieCup.FreezeMultipleDice(s);
                        dieCup.PrintEyes(rollCount);
                        Console.WriteLine("\nIndtast numrene på de terninger, du vil låse (op), eller tryk på Enter for at rafle.\n");
                        Console.WriteLine(currentPlayer.GetName() + "'s turn");
                        Console.WriteLine("Round: " + currentRound);

                    }
                }
                else
                {
                    dieCup.FreezeAllDice();
                    dieCup.PrintEyes(rollCount);
                    Console.WriteLine("\nKlasse raflet! Tryk på Enter for at afslutte din tur.\n");
                    Console.ReadLine();
                    Console.Clear();
                }
                rollCount++;

                //if (rollCount < 3)
                //{
                //    handleFreeze();
                //}
            }


        }

        public void ChangeTurn()
        {
            int currentIndex = players.IndexOf(currentPlayer);
            currentIndex++;

            if (currentIndex >= players.Count)
            {
                currentIndex = 0;
            }

            currentPlayer = players[currentIndex];
        }

        public void SetPlayerName(int index, string name)
        {
            players[index].SetName(name);
        }
      

    }
}
