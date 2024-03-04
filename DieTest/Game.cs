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

            dieCup.Roll();





        }




    }
}
