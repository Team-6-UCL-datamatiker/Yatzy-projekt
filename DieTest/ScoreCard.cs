using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DieTest
{
    internal class ScoreCard
    {
        public void PrintScoreCard(Player[] pA)
        {
            Console.Clear();
            Console.Write(new string(' ', 35) + "Spillere:           " + "| ");
            foreach (Player p in pA)
            {
                p.PrintName();
            }
            Console.Write("\n" + new string(' ', 55) + "| ");
            foreach (Player p in pA)
            {
                Console.Write(new string(' ', 10) + "| ");
            }
            Console.Write("\n" + new string(' ', 35) + "1:  1’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Enere);
            }
            Console.Write("\n" + new string(' ', 35) + "2:  2’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Toere);
            }
            Console.Write("\n" + new string(' ', 35) + "3:  3’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Treere);
            }
            Console.Write("\n" + new string(' ', 35) + "4:  4’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Firere);
            }
            Console.Write("\n" + new string(' ', 35) + "5:  5’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Femmere);
            }
            Console.Write("\n" + new string(' ', 35) + "6:  6’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Seksere);
            }
            Console.Write("\n" + new string(' ', 35) + "    Bonus__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Bonus);
            }
            Console.Write("\n" + new string(' ', 35) + "7:  Et par_________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.EtPar);
            }
            Console.Write("\n" + new string(' ', 35) + "8:  To par_________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ToPar);
            }
            Console.Write("\n" + new string(' ', 35) + "9:  Tre ens________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.TreEns);
            }
            Console.Write("\n" + new string(' ', 35) + "10: Fire ens_______ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.FireEns);
            }
            Console.Write("\n" + new string(' ', 35) + "11: Lille Straight_ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.LilleStraight);
            }
            Console.Write("\n" + new string(' ', 35) + "12: Stor Straight__ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.StorStraight);
            }
            Console.Write("\n" + new string(' ', 35) + "13: Chancen________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Chancen);
            }
            Console.Write("\n" + new string(' ', 35) + "14: Yatzy__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Yatzy);
            }
            Console.Write("\n" + new string(' ', 55) + "| ");
            foreach (Player p in pA)
            {
                Console.Write(new string(' ', 10) + "| ");
            }
            Console.Write("\n" + new string(' ', 35) + "Samlet Score:       " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.TotalScore);
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}
