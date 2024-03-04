using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Game
    {
        
        
        static void Main(string[] args)

        {
            Misc misc = new Misc();
            DieCup dieCup = new DieCup();
            int maxLength = 10;

            //  Intro and set up

            misc.Title();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\n \n Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("How many players?");
            int numberofplayers = int.Parse(Console.ReadLine());
            Player[] players = new Player[numberofplayers];

            for (int i = 0; i < numberofplayers; i++)
            {
                string x;

                do
                {
                    Console.WriteLine("Name of player " + (i + 1) + "?:");
                    x = Console.ReadLine();

                    if (x.Length > maxLength)
                    {
                        Console.WriteLine($"Input exceeds maximum length of {maxLength} characters. Please try again.");
                    }
                }
                while (x.Length > maxLength);
                
                players[i] = new Player(x, i);


                
            }

            Console.Clear();
            Scoreboard.showScoreboard(players);

            //Turn 1

            for (int i = 0;i < 3; i++)
            {
                dieCup.Roll();
                Console.Clear();
                dieCup.PrintEyes(i);

                if (i != 2)
                {
                    Console.WriteLine("Would you like to freeze/unfreeze any? y/n");

                    ConsoleKeyInfo keyInfo;
                    do
                    {
                        keyInfo = Console.ReadKey(true);
                    } while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N);

                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("Enter the dice number of those you'd like to freeze/unfreeze (not the results):");
                        dieCup.FreezeMultipleDice(Console.ReadLine());
                    }
                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                
                    }


                }
                Console.Clear();
            }

            Scoreboard.showScoreboard(players);
            Console.WriteLine();
            dieCup.PrintEyes(2);
            Console.WriteLine("Choose where to save the results (Type the number of the catagory you'd like to save the result in):");
            









        }




    }
}
