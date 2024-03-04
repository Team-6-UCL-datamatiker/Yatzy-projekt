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
            //Working part, for reference

            //Console.WriteLine("How many players?");
            //int numberofplayers = int.Parse(Console.ReadLine());
            //Player[] players = new Player[numberofplayers];

            //for (int i = 0; i < numberofplayers; i++)
            //{
            //   Console.WriteLine("Name of player " + (i+1) + "?:");
            //    string x = Console.ReadLine();
            //    players[i] = new Player(x, i);
            //}

            //Console.Clear();
            //Scoreboard.showScoreboard(players);

            //

            //  Intro and set up

            misc.Title();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\n \n Press any key to continue...");
            Console.ReadKey();
            Console.Clear();


        }




    }
}
