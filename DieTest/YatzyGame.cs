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

        public YatzyGame(int numberOfPlayers)
        {
            players = new List<Player>();
            dieCup = new DieCup();
            currentRound = 1;

            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player());
            }
            currentPlayer = players[0];
        }

        public void StartGame()
        {
            RegisterNames();
            for (int i = currentRound; i <= 14; i++) //Round (14 total)
            {
                for (int j = 0; j < players.Count; j++) //Turn (1 for each player per round)
                {
                    PlayTurn();
                    ChangeTurn();
                }
            }
            EndGame();
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
                    if (name != null && name != "")
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
            while (rollCount < 3) //1. roll
            {

                for (int j = 0; j < 20; j++)
                {
                    dieCup.Roll();
                    dieCup.PrintEyes(rollCount);
                    Console.WriteLine("\nRafle rafle rafle...\n");
                    Thread.Sleep(25);
                }
                Console.WriteLine(currentPlayer.GetName() + "'s turn");
                Console.WriteLine("Round: " + currentRound);

                int[] diceValues = dieCup.GetDiceValues();

                if (rollCount < 2) //next 2 rolls
                {
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    dieCup.FreezeAllDice();
                    dieCup.PrintEyes(rollCount);
                    Console.WriteLine("\nKlasse raflet " + currentPlayer.GetName() + "! Tryk på Enter for at vælge katagori.\n");
                    Console.ReadLine();
                    Console.Clear();
                    Console.ResetColor();
                    //set scoreboard
                    string selectedCategory = GetCatagory(); // Get the category from the player
                    HandleScoreboardUpdate(selectedCategory, diceValues); //updates scoreboard
                }
                rollCount++;

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

        //Updates and prints scoreboard of current player
        public void HandleScoreboardUpdate(string catagory, int[] diceValues)
        {
            Scoreboard playerScoreboard = currentPlayer.PlayerScoreboard;
            playerScoreboard.SetScore(catagory, diceValues);
            playerScoreboard.PrintScoreboard();
            Console.ReadLine();
        }

        //Takes input from player returns the catagory.
        public string GetCatagory()
        {
            Console.WriteLine("Choose a catagory (Ones, Twos, ... Yatzy)");
            string catagory = Console.ReadLine().ToUpper();
            return catagory;
        }

        public Player CalculateWinner()
        {
            Player winner = players[0];

            foreach (Player player in players)
            {
                if (player.PlayerScoreboard.GetTotalScore() > winner.PlayerScoreboard.GetTotalScore())
                {
                    winner = player;
                }
            }
            return winner;
        }

        public void EndGame()
        {
            Player winner = CalculateWinner();
            for (int i = 0; i < 100; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CONGRATULATIONS " + winner.GetName() + " YOU WON!!!!!! \n Points: " + winner.PlayerScoreboard.GetTotalScore());
                System.Threading.Thread.Sleep(10);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCONGRATULATIONS " + winner.GetName() + " YOU WON!!!!!! \n Points: " + winner.PlayerScoreboard.GetTotalScore());
                System.Threading.Thread.Sleep(10);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nCONGRATULATIONS " + winner.GetName() + " YOU WON!!!!!! \n Points: " + winner.PlayerScoreboard.GetTotalScore());
                System.Threading.Thread.Sleep(10);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nCONGRATULATIONS " + winner.GetName() + " YOU WON!!!!!! \n Points: " + winner.PlayerScoreboard.GetTotalScore());
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
