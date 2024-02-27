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
            Console.Write(new string(' ', 40) + "Spillere:           " + "| ");
            foreach (Player p in pA)
            {
                p.PrintName();
            }
            Console.Write("\n" + new string(' ', 60) + "| ");
            foreach (Player p in pA)
            {
                Console.Write(new string(' ', 10) + "| ");
            }
            Console.Write("\n" + new string(' ', 40) + "1:  1’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Enere, p.EnereB);
            }
            Console.Write("\n" + new string(' ', 40) + "2:  2’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Toere, p.ToereB);
            }
            Console.Write("\n" + new string(' ', 40) + "3:  3’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Treere, p.TreereB);
            }
            Console.Write("\n" + new string(' ', 40) + "4:  4’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Firere, p.FirereB);
            }
            Console.Write("\n" + new string(' ', 40) + "5:  5’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Femmere, p.FemmereB);
            }
            Console.Write("\n" + new string(' ', 40) + "6:  6’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Seksere, p.SeksereB);
            }
            Console.Write("\n" + new string(' ', 40) + "    Bonus__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Bonus, p.BlankB);
            }
            Console.Write("\n" + new string(' ', 40) + "7:  Et par_________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.EtPar, p.EtParB);
            }
            Console.Write("\n" + new string(' ', 40) + "8:  To par_________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ToPar, p.ToParB);
            }
            Console.Write("\n" + new string(' ', 40) + "9:  Tre ens________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.TreEns, p.TreEnsB);
            }
            Console.Write("\n" + new string(' ', 40) + "10: Fire ens_______ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.FireEns, p.FireEnsB);
            }
            Console.Write("\n" + new string(' ', 40) + "11: Lille Straight_ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.LilleStraight, p.LilleStraightB);
            }
            Console.Write("\n" + new string(' ', 40) + "12: Stor Straight__ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.StorStraight, p.StorStraightB);
            }
            Console.Write("\n" + new string(' ', 40) + "13: Chancen________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Chancen, p.ChancenB);
            }
            Console.Write("\n" + new string(' ', 40) + "14: Yatzy__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Yatzy, p.YatzyB);
            }
            Console.Write("\n" + new string(' ', 60) + "| ");
            foreach (Player p in pA)
            {
                Console.Write(new string(' ', 10) + "| ");
            }
            Console.Write("\n" + new string(' ', 40) + "Samlet Score:       " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.TotalScore, p.BlankB);
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}
