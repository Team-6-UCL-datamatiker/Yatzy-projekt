using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class GameHelper
    {
        public int NoOfPlayers(string s)
        {
            int i = 0;
            while (i < 2 || i > 5)
            {
                switch (s)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                        Console.Clear();
                        i = int.Parse(s);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Indtast et tal mellem 2 og 5.\n");
                        s = Console.ReadLine();
                        break;
                }
            }
            return i;
        }

        public Player[] CreatePlayers(int i)
        {
            Player[] pA = new Player[i];
            for (int j = i;  j > 0; j--)
            {
                Console.WriteLine("Enter the name of player {0} (Max 9 tegn):\n", (i-j+1));
                pA[i-j] = new Player();
                while (((pA[i - j]).Name).Length > 9)
                {
                    Console.Clear();
                    Console.WriteLine("Indtast et navn på max 9 tegn:\n");
                    pA[i - j].Name = Console.ReadLine();
                }
                Console.Clear();
            }
            return pA;
        }
    }
}
