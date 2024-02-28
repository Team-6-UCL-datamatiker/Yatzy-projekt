using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DieTest
{
    public class Scoreboard
    {
        public static void showScoreboard(Player[] players) 
        {
            //Creating Header
            Console.Write("Kombination".PadRight(25));
            foreach (var player in players)
            {
                Console.Write($"{player.name}".PadRight(10));
            }
            Console.WriteLine();
            //Creating Rows
            foreach (var key in players[0].scores.Keys)
            {
                Console.Write(key.PadRight(25));

                foreach (var player in players)
                {
                    Console.Write($"{player.scores[key]}".PadRight(10));
                }
                Console.WriteLine();

            }
            

            //for (int i = 1; i < 14; i++)
            //{
            //    Console.Write();
            //}


        }
    }
}
