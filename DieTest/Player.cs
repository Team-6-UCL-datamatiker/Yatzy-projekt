using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Player
    {
        // Feltvariable/Properties:
        public string Name { get; set; }
        public string Color { get; set; }
        public string SecondaryColor { get; set; }
        //Oversigt over arrays
        // 0 = Enere
        // 1 = Toere
        // 2 = Treere
        // 3 = Firere
        // 4 = Femmere
        // 5 = Seksere
        // 6 = Et par
        // 7 = To par
        // 8 = Tre ens
        // 9 = Fire ens
        // 10 = Lille Straight
        // 11 = Stor Straight
        // 12 = Chancen
        // 13 = Yatzy
        // 14 = Bonus
        // 15 = Total Score
        private int[] scoreArray = new int[16];
        public int[] ScoreArray { get { return scoreArray; } }
        private bool[] boolArray = new bool[16];
        public bool[] BoolArray { get { return boolArray; } }

        // Constructor:
        public Player(string sName, string sColor, string sSecondaryColor)
        {
            Name = sName;
            Color = sColor;
            SecondaryColor = sSecondaryColor;

        }
    }
}
