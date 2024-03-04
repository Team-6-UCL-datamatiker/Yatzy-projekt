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
            int cat = 1;
            //Creating Header
            Console.Write("".PadRight(4) + "Kombination".PadRight(25));
            foreach (var player in players)
            {
                Console.Write($"{player.name}".PadRight(10));
            }
            Console.WriteLine();
            //Creating Rows
            foreach (var key in players[0].scores.Keys)
            {
                Console.Write((cat + ": ").PadRight(4) + key.PadRight(25));
                cat++;
                foreach (var player in players)
                {
                    Console.Write($"{player.scores[key]}".PadRight(10));
                }
                Console.WriteLine();

            }
        }
    }
}
