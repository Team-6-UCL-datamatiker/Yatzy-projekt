using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Player
    {
        public string Name { get; set; }
        public int Enere { get; set; }
        public int Toere { get; set; }
        public int Treere { get; set; }
        public int Firere { get; set; }
        public int Femmere { get; set; }
        public int Seksere { get; set; }
        public int Bonus { get; set; }
        public int EtPar { get; set; }
        public int ToPar { get; set; }
        public int TreEns { get; set; }
        public int FireEns { get; set; }
        public int LilleStraight { get; set; }
        public int StorStraight { get; set; }
        public int Chancen { get; set; }
        public int Yatzy { get; set; }
        public int TotalScore { get; set; }

        public Player()
        {
            Name = Console.ReadLine();
        }

        public void PrintName()
        {
            int l = 10 - Name.Length;
            int hl = l / 2;
            int ml = l % 2;
            Console.Write(new string(' ', hl) + Name + new string(' ', hl + ml) + "| ");
        }

        public void PrintProperty(int i)
        {
            int l = 10 - (i.ToString()).Length;
            int hl = l / 2;
            int ml = l % 2;
            Console.Write(new string(' ', hl) + i + new string(' ', hl + ml) + "| ");
        }
    }
}
