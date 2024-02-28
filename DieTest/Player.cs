using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Player
    {
        // Feltvariable/Properties:
        //
        public string Name { get; set; }
        public int Bonus { get; set; }
        public int TotalScore { get; set; }
        public bool FillerB { get; set; }
        private int[] scoreArray = new int[14];
        public int[] ScoreArray { get { return scoreArray; } }
        private bool[] boolArray = new bool[14];
        public bool[] BoolArray { get { return boolArray; } }
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

        // Constructor:
        //
        public Player()
        {
            Name = Console.ReadLine();
        }

        // Metoder:
        //
        public void PrintName()
        {
            int l = 10 - Name.Length;
            int hl = l / 2;
            int ml = l % 2;
            Console.Write(new string(' ', hl) + Name + new string(' ', hl + ml - 1) + " | ");
        }
        public void PrintProperty(int i, bool b)
        {
            if (b == false)
            {
                int l = 10 - (i.ToString()).Length;
                int hl = l / 2;
                int ml = l % 2;
                Console.Write(new string(' ', hl - 1) + " " + i + " " + new string(' ', hl + ml - 2) + " | ");
            }
            else
            {
                int l = 10 - (i.ToString()).Length;
                int hl = l / 2;
                int ml = l % 2;
                Console.Write(new string(' ', hl - 1) + "[" + i + "]" + new string(' ', hl + ml - 2) + " | ");
            }
        }
        public void CalculateBonus()
        {
            if (Bonus == 0 && scoreArray[0] + scoreArray[1] + scoreArray[2] + scoreArray[3] + scoreArray[4] + scoreArray[5] >= 63 )
            {
                Bonus = 50;
                TotalScore += Bonus;
            }
        }
        public bool SetScore(string s, string scoreNavn, DataCruncher c, bool b, DieCup dC)
        {
            int i = int.Parse(s) - 1;
            if (boolArray[i] == true)
            {
                Console.WriteLine("\nDu har allerede valgt {0}", scoreNavn);
                b = false;
            }
            else
            {
                Console.Write("\nDin {0} score er {1}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", scoreNavn, c.Calculate(dC, s));
                while (true)
                {
                    string a = Console.ReadLine();
                    if (a == "hov vent")
                    {
                        b = false;
                        break;
                    }
                    else if (a != "")
                    {
                        Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                    }
                    else
                    {
                        scoreArray[i] = c.Calculate(dC, s);
                        boolArray[i] = true;
                        TotalScore += scoreArray[i];
                        break;
                    }
                }
            }
            return b;
        }
        public void SetScoreSorter(DieCup dC)
        {
            DataCruncher c = new DataCruncher();
            bool b = true;
            do
            {
                Console.Write("\nIndtast et tal mellem 1 og 14 for at vælge kombination: ");
                string s = Console.ReadLine();
                string scoreNavn = "";
                b = true;
                switch (s)
                {
                    case "1":
                        scoreNavn = "1'ere";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        CalculateBonus();
                        break;
                    case "2":
                        scoreNavn = "2'ere";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        CalculateBonus();
                        break;
                    case "3":
                        scoreNavn = "3'ere";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        CalculateBonus();
                        break;
                    case "4":
                        scoreNavn = "4'ere";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        CalculateBonus();
                        break;
                    case "5":
                        scoreNavn = "5'ere";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        CalculateBonus();
                        break;
                    case "6":
                        scoreNavn = "6'ere";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        CalculateBonus();
                        break;
                    case "7":
                        scoreNavn = "Et par";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        break;
                    case "8":
                        scoreNavn = "To par";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        break;
                    case "9":
                        scoreNavn = "Tre ens";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        break;
                    case "10":
                        scoreNavn = "Fire ens";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        break;
                    case "11":
                        scoreNavn = "Lille straight";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        break;
                    case "12":
                        scoreNavn = "Stor straight";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        break;
                    case "13":
                        scoreNavn = "Chancen";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        break;
                    case "14":
                        scoreNavn = "Yatzy";
                        b = SetScore(s, scoreNavn, c, b, dC);
                        break;
                    default:
                        b = false;
                        break;
                }
            } while (b == false);
        }
    }
}
