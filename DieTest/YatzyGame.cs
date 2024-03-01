using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
                players.Add(new Player()); //Makes how many new players specified and adds them to the list
            }
            currentPlayer = players[0]; //Sets starting player to the first object in the list
        }

        //:-)
        public void StartGame()
        {           
            RegisterNames();

            for (int i = currentRound; i <= 2; i++) //Round (14 total)
            {
                for (int j = 0; j < players.Count; j++) //Turn (1 for each player per round)
                {
                    PlayTurn();
                    ChangeTurn();
                }
            }
            EndGame(); //Ends game and prints winner
        }

        //sets name of each player 
        public void RegisterNames()
        {
            Console.Clear();
            for (int i = 1; i <= players.Count; i++)
            {
                while (true)
                {
                    TypeLine("Name of player" + i + ": ");
                    string name = Console.ReadLine();
                    if (name != null && name != "")
                    {
                        SetPlayerName(i - 1, name);
                        break;
                    }
                    else
                    {
                        TypeLine("Please type something!\n");
                    }
                }
            }
        }

        //Hanldes each turn
        public void PlayTurn()
        {
            Console.Clear();
            SetPlayerColor(currentPlayer); //Sets terminal color to the current players color
            dieCup.UnfreezeAllDice(); //starts with unfrozen dice on new turn

            //rolling
            for (int rollCount = 0; rollCount < 3; rollCount++)
            {
                RollAnimation(rollCount);

                int[] diceValues = dieCup.GetDiceValues();

                if (rollCount < 2) //after first and second roll
                {
                    HandleFreeze(rollCount);
                }
                else //after final roll
                {
                    UpdateScoreBoardAndEndTurn(rollCount, diceValues);
                }
            }
        }

        //Prints the roll animation
        public void RollAnimation(int rollCount)
        {
            for (int j = 0; j < 20; j++)
            {
                dieCup.Roll();
                dieCup.PrintEyes(rollCount, GetPlayerColor(currentPlayer));
                Console.WriteLine("\nRafle rafle rafle...\n");
                Thread.Sleep(25);
            }
            Console.WriteLine("Round: " + currentRound);
            Console.WriteLine(currentPlayer.GetName() + "'s turn");
        }

        //Freezes the selected dice
        public void HandleFreeze(int rollCount)
        {
            string input = "";

            do
            {
                Console.WriteLine("\nIndtast numrene på de terninger, du vil låse (op), eller tryk på Enter for at rafle.\n");
                input = Console.ReadLine();
                dieCup.FreezeMultipleDice(input);
                dieCup.PrintEyes(rollCount, GetPlayerColor(currentPlayer));
                Console.WriteLine("\nRound: " + currentRound);
                Console.WriteLine(currentPlayer.GetName() + "'s turn");
            }
            while (input != "");
        }

        //Updates scoreboard, prints it and ends player turn
        public void UpdateScoreBoardAndEndTurn(int rollCount, int[] diceValues)
        {
            dieCup.FreezeAllDice();
            dieCup.PrintEyes(rollCount, GetPlayerColor(currentPlayer));
            Console.WriteLine("\nKlasse raflet " + currentPlayer.GetName() + "! Tryk på Enter for at vælge katagori.\n");
            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();

            //set scoreboard
            string selectedCategory = GetCatagory(); // Get the category from the player
            HandleScoreboardUpdate(selectedCategory, diceValues); //updates scoreboard
        }

        //Changes turn - sets currentPlayer to next player
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

        //Sets the name of the player on the given index
        public void SetPlayerName(int index, string name)
        {
            players[index].SetName(name);
        }

        //Makes terminal color different depending on player
        public void SetPlayerColor(Player player)
        {
            switch (players.IndexOf(player))
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        public ConsoleColor GetPlayerColor(Player player)
        {
            switch (players.IndexOf(player))
            {
                case 0:
                    return ConsoleColor.Blue;
                case 1:
                    return ConsoleColor.Green;
                case 2:
                    return ConsoleColor.Yellow;
                case 3:
                    return ConsoleColor.Cyan;
                case 4:
                    return ConsoleColor.Magenta;
                default:
                    return ConsoleColor.White;
            }
        }

        //Updates and prints scoreboard of current player (used in UpdateScoreBoardAndEndTurn)
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
            currentPlayer.PlayerScoreboard.PrintScoreboard();
            Console.WriteLine("Choose a catagory (Ones, Twos, ... Yatzy)");
            string catagory = Console.ReadLine().ToUpper();
            return catagory;
        }

        //Return the player with the highest total score
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

        //Prints a wholesome end game message and player ranking
        public void EndGame()
        {
            Player winner = CalculateWinner();
            for (int i = 0; i < 10; i++)
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
            Console.Clear();
            Console.ResetColor();
            Player[] sortedPlayersArray = players.OrderByDescending(player => player.PlayerScoreboard.GetTotalScore()).ToArray();
            for (int i = 0; i < sortedPlayersArray.Length; i++)
            {
                SetPlayerColor(sortedPlayersArray[i]);
                Console.WriteLine(i + 1 + ". place: " + sortedPlayersArray[i].GetName() + " (" + sortedPlayersArray[i].PlayerScoreboard.GetTotalScore() + " points)");
            }
            Console.ResetColor();
        }

        //Typing animation!
        public void TypeLine(String line)
        {
            foreach (char c in line)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}
