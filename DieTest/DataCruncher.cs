using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DieTest
{
    internal class DataCruncher
    {
        // Metoder:
        //

        // Spilleroprettelse:
        public Player[] CreateNumberOfPlayers()
        {
            Console.WriteLine("Velkommen til Yatzy.");
            Console.WriteLine("\nIndtast antallet af spillere (1-5).\n");
            string sDeclaredPlayers = Console.ReadLine();
            int iNumberOfPlayers = 0;
            while (iNumberOfPlayers < 1 || iNumberOfPlayers > 5)
            {
                switch (sDeclaredPlayers)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                        Console.Clear();
                        iNumberOfPlayers = int.Parse(sDeclaredPlayers);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Indtast et tal mellem 1 og 5.\n");
                        sDeclaredPlayers = Console.ReadLine();
                        break;
                }
            }
            Player[] playerArray = new Player[iNumberOfPlayers];
            for (int i = iNumberOfPlayers; i > 0; i--)
            {
                Console.Write("Spiller {0}: ", iNumberOfPlayers - i + 1);
                playerArray[iNumberOfPlayers - i] = new Player();
                
                while (playerArray[iNumberOfPlayers - i].Name.Length > 9 || playerArray[iNumberOfPlayers - i].Name.Length < 3)
                {
                    Console.Clear();
                    Console.WriteLine("Indtast et navn på mellem 3 og 9 tegn, spiller {0}:\n", iNumberOfPlayers - i + 1);
                    playerArray[iNumberOfPlayers - i].Name = Console.ReadLine();
                }
                Console.Clear();
            }
            return playerArray;
        }

        // Scoreberegning:
        public int CalculateSpecifiedScore(DieCup dieCup, string s)
        {
            int[] dieArrayEyes = dieCup.GetDiceValues();
            switch (s)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                    return OnesToSixes(s, dieArrayEyes);
                case "7":
                    return Pair(dieArrayEyes);
                case "8":
                    return TwoPairs(dieArrayEyes);
                case "9":
                    return ThreeOfAKind(dieArrayEyes);
                case "10":
                    return FourOfAKind(dieArrayEyes);
                case "11":
                    return SmallStraight(dieArrayEyes);
                case "12":
                    return BigStraight(dieArrayEyes);
                case "13":
                    return Chance(dieArrayEyes);
                case "14":
                    return Yatzy(dieCup);
                default:
                    return 1000000;
            }
        }
        public int OnesToSixes(string s, int[] dieArrayEyes) //check outofbouds erorors
        {
            int sum = 0;
            int categoryValue = int.Parse(s);

            foreach (int i in dieArrayEyes)
            {
                if (i == categoryValue)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public int Pair(int[] dieArrayEyes)
        {
            Array.Sort(dieArrayEyes); //sort by value
            Array.Reverse(dieArrayEyes); //get the highest value first

            for (int i = 0; i < dieArrayEyes.Length; i++)
            {
                if (dieArrayEyes[i] == dieArrayEyes[i + 1])
                {
                    return dieArrayEyes[i] * 2;
                }
            }
            return 0;
        }
        public int TwoPairs(int[] dieArrayEyes)
        {
            int sum = 0;
            int pairCount = 0;
            Array.Sort(dieArrayEyes);
            Array.Reverse(dieArrayEyes);

            for (int i = 0; i < dieArrayEyes.Length; i++)
            {
                if (dieArrayEyes[i] == dieArrayEyes[i + 1])
                {
                    sum += dieArrayEyes[i] * 2;
                    pairCount++;

                    if (pairCount == 2)
                    {
                        break;
                    }
                    i++;
                }
            }
            if (pairCount == 2)
            {
                return sum;
            }
            else
            {
                return 0;
            }
        }//check outofbouds errors
        public int ThreeOfAKind(int[] dieArrayEyes)
        {
            Array.Sort(dieArrayEyes);

            for (int i = 0; i < dieArrayEyes.Length; i++)
            {
                if (dieArrayEyes[i] == dieArrayEyes[i + 1] && dieArrayEyes[i] == dieArrayEyes[i + 2])
                {
                    return dieArrayEyes[i] * 3;
                }
            }
            return 0;
        } //check outofbouds erros outofbouds erros
        public int FourOfAKind(int[] dieArrayEyes)
        {
            Array.Sort(dieArrayEyes);

            for (int i = 0; i < dieArrayEyes.Length; i++)
            {
                if (dieArrayEyes[i] == dieArrayEyes[i + 1] && dieArrayEyes[i] == dieArrayEyes[i + 2] && dieArrayEyes[i] == dieArrayEyes[i + 3])
                {
                    return dieArrayEyes[i] * 4;
                }
            }
            return 0;
        }
        public int SmallStraight(int[] dieArrayEyes)
        {
            Array.Sort(dieArrayEyes);

            for (int i = 0; i < 5; i++)
            {
                if (dieArrayEyes[i] != i + 1) //checking if dice1 = 1, dice 2 = 2 and so on..
                {
                    return 0;
                }
            }
            return 15;
        }
        public int BigStraight(int[] dieArrayEyes)
        {
            Array.Sort(dieArrayEyes);

            for (int i = 0; i < 5; i++)
            {
                if (dieArrayEyes[i] != i + 2) //checking if dice1 = 2, dice 2 = 3 and so on..
                {
                    return 0;
                }
            }
            return 20;
        }
        public int Chance(int[] dieArrayEyes)
        {
            int sum = 0;
            foreach (int value in dieArrayEyes)
            {
                sum += value;
            }
            return sum;
        }
        public int Yatzy(DieCup dC)
        {
            int iEyes = dC.DieArray[0].Eyes;
            foreach (Die d in dC.DieArray)
            {
                if (d.Eyes != iEyes)
                {
                    return 0;
                }
            }
            return 50;
        }
        public void CalculateBonus(Player p)
        {
            if (p.ScoreArray[14] == 0 && p.ScoreArray[0] + p.ScoreArray[1] + p.ScoreArray[2] + p.ScoreArray[3] + p.ScoreArray[4] + p.ScoreArray[5] >= 63)
            {
                p.ScoreArray[14] = 50;
                p.ScoreArray[15] += p.ScoreArray[14];
            }
        }

        // Printere:
        public void PrintName(Player p)
        {
            int l = 10 - p.Name.Length;
            int hl = l / 2;
            int ml = l % 2;
            Console.Write(new string(' ', hl) + p.Name + new string(' ', hl + ml - 1) + " | ");
        }
        public string PrintIsFrozen(Die d)
        {
            if (d.IsFrozen == true)
            {
                return "[X] ";
            }
            else
            {
                return "[ ] ";
            }
        }
        public void PrintDieEyes(int i, DieCup dC)
        {
            Console.WriteLine((i + 1) + ". Rul\n");
            foreach (Die d in dC.DieArray)
            {
                Console.WriteLine(PrintIsFrozen(d) + "Terning " + (Array.IndexOf(dC.DieArray, d) + 1) + ": " + d.Eyes);
            }
        }
        public void PrintSpecifiedScore(int i, bool b)
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
        public void PrintScoreCard(Player[] pA)
        {
            Console.Clear();
            Console.Write(new string(' ', 40) + "Spillere:           " + "| ");
            foreach (Player p in pA)
            {
                PrintName(p);
            }
            Console.Write("\n" + new string(' ', 60) + "| ");
            foreach (Player p in pA)
            {
                Console.Write(new string(' ', 10) + "| ");
            }
            Console.Write("\n" + new string(' ', 40) + "1:  1’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[0], p.BoolArray[0]);
            }
            Console.Write("\n" + new string(' ', 40) + "2:  2’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[1], p.BoolArray[1]);
            }
            Console.Write("\n" + new string(' ', 40) + "3:  3’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[2], p.BoolArray[2]);
            }
            Console.Write("\n" + new string(' ', 40) + "4:  4’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[3], p.BoolArray[3]);
            }
            Console.Write("\n" + new string(' ', 40) + "5:  5’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[4], p.BoolArray[4]);
            }
            Console.Write("\n" + new string(' ', 40) + "6:  6’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[5], p.BoolArray[5]);
            }
            Console.Write("\n" + new string(' ', 40) + "    Bonus__________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[14], p.BoolArray[14]);
            }
            Console.Write("\n" + new string(' ', 40) + "7:  Et par_________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[6], p.BoolArray[6]);
            }
            Console.Write("\n" + new string(' ', 40) + "8:  To par_________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[7], p.BoolArray[7]);
            }
            Console.Write("\n" + new string(' ', 40) + "9:  Tre ens________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[8], p.BoolArray[8]);
            }
            Console.Write("\n" + new string(' ', 40) + "10: Fire ens_______ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[9], p.BoolArray[9]);
            }
            Console.Write("\n" + new string(' ', 40) + "11: Lille Straight_ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[10], p.BoolArray[10]);
            }
            Console.Write("\n" + new string(' ', 40) + "12: Stor Straight__ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[11], p.BoolArray[11]);
            }
            Console.Write("\n" + new string(' ', 40) + "13: Chancen________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[12], p.BoolArray[12]);
            }
            Console.Write("\n" + new string(' ', 40) + "14: Yatzy__________ " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[13], p.BoolArray[13]);
            }
            Console.Write("\n" + new string(' ', 60) + "| ");
            foreach (Player p in pA)
            {
                Console.Write(new string(' ', 10) + "| ");
            }
            Console.Write("\n" + new string(' ', 40) + "Samlet Score:       " + "| ");
            foreach (Player p in pA)
            {
                PrintSpecifiedScore(p.ScoreArray[15], p.BoolArray[15]);
            }
            Console.SetCursorPosition(0, 0);
        }
        public void PrintTurn(Player[] pA, Player p)
        {
            Console.Clear();
            PrintScoreCard(pA);
            Console.Write(p.Name + "s tur:\n\n");
        }

        // Scoreopdatering:
        public void SetScoreSorter(DieCup dC, Player p)
        {
            bool b = true;
            while (b == true)
            {
                Console.Write("\nIndtast et tal mellem 1 og 14 for at vælge kombination: ");
                string s = Console.ReadLine();
                string scoreNavn;
                b = false;
                switch (s)
                {
                    case "1":
                        scoreNavn = "1'ere";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        CalculateBonus(p);
                        break;
                    case "2":
                        scoreNavn = "2'ere";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        CalculateBonus(p);
                        break;
                    case "3":
                        scoreNavn = "3'ere";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        CalculateBonus(p);
                        break;
                    case "4":
                        scoreNavn = "4'ere";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        CalculateBonus(p);
                        break;
                    case "5":
                        scoreNavn = "5'ere";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        CalculateBonus(p);
                        break;
                    case "6":
                        scoreNavn = "6'ere";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        CalculateBonus(p);
                        break;
                    case "7":
                        scoreNavn = "Et par";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        break;
                    case "8":
                        scoreNavn = "To par";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        break;
                    case "9":
                        scoreNavn = "Tre ens";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        break;
                    case "10":
                        scoreNavn = "Fire ens";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        break;
                    case "11":
                        scoreNavn = "Lille straight";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        break;
                    case "12":
                        scoreNavn = "Stor straight";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        break;
                    case "13":
                        scoreNavn = "Chancen";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        break;
                    case "14":
                        scoreNavn = "Yatzy";
                        b = SetScore(s, scoreNavn, b, dC, p);
                        break;
                    default:
                        b = true;
                        break;
                }

            }
        }
        public bool SetScore(string s, string scoreNavn, bool b, DieCup dC, Player p)
        {
            int i = int.Parse(s) - 1;
            if (p.BoolArray[i] == true)
            {
                Console.WriteLine("\nDu har allerede valgt {0}", scoreNavn);
                b = true;
            }
            else
            {
                Console.Write("\nDin {0} score er {1}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", scoreNavn, CalculateSpecifiedScore(dC, s));
                while (true)
                {
                    string a = Console.ReadLine();
                    if (a == "hov vent")
                    {
                        b = true;
                        break;
                    }
                    else if (a != "")
                    {
                        Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                    }
                    else
                    {
                        p.ScoreArray[i] = CalculateSpecifiedScore(dC, s);
                        p.BoolArray[i] = true;
                        p.ScoreArray[15] += p.ScoreArray[i];
                        break;
                    }
                }
            }
            return b;
        }




    }
}
