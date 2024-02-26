using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class ScoreCard
    {
        public void PrintScoreCard(Player[] pA)
        {
            Console.Clear();
            Console.Write("Spillere___________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintName();
            }
            Console.Write("\n1’ere______________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Enere);
            }
            Console.Write("\n2’ere______________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Toere);
            }
            Console.Write("\n3’ere______________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Treere);
            }
            Console.Write("\n4’ere______________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Firere);
            }
            Console.Write("\n5’ere______________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Femmere);
            }
            Console.Write("\n6’ere______________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Seksere);
            }
            Console.Write("\nBonus______________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Bonus);
            }
            Console.Write("\nEt par_____________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.EtPar);
            }
            Console.Write("\nTo par_____________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ToPar);
            }
            Console.Write("\nTre ens____________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.TreEns);
            }
            Console.Write("\nFire ens___________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.FireEns);
            }
            Console.Write("\nLille Straight_____ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.LilleStraight);
            }
            Console.Write("\nStor Straight______ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.StorStraight);
            }
            Console.Write("\nChancen____________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Chancen);
            }
            Console.Write("\nYatzy______________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Yatzy);
            }
            Console.Write("\nSamlet Score_______ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.TotalScore);
            }
            Console.WriteLine("\n");
        }
    }
}
