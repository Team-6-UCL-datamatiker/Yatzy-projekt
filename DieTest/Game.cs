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

            for (int i = 0; i < numberofplayers; i++)
            {
                
                Console.WriteLine("Name of player " + (i+1) + "?:");
                string x = Console.ReadLine();
                Player  = new Player(x, i);
            }


        }




    }
}
