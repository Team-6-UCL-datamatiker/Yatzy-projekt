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
            Console.WriteLine("How many players?");
            int numberofplayers = int.Parse(Console.ReadLine());
            Player[] players = new Player[numberofplayers];

            for (int i = 0; i < numberofplayers; i++)
            {
               Console.WriteLine("Name of player " + (i+1) + "?:");
                string x = Console.ReadLine();
                players[i] = new Player(x, i);
            }

            Console.WriteLine(players[1].name);
            Console.WriteLine(players[1].scores["1'ere"]);

            players[1].SetScore("1'ere", 10);
            players[1].SetScore("1'ere", 16);

            Console.WriteLine(players[1].GetScore("1'ere"));
        }




    }
}
