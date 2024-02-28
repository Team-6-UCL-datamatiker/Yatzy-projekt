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
        public int Calculate(DieCup dC, string s)
        {
            switch (s)
            {
                case "1":
                    return Enere(dC);
                    break;
                case "2":
                    return Toere(dC);
                    break;
                case "3":
                    return Treere(dC);
                    break;
                case "4":
                    return Firere(dC);
                    break;
                case "5":
                    return Femmere(dC);
                    break;
                case "6":
                    return Seksere(dC);
                    break;
                case "7":
                    return EtPar(dC);
                    break;
                case "8":
                    return ToPar(dC);
                    break;
                case "9":
                    return TreEns(dC);
                    break;
                case "10":
                    return FireEns(dC);
                    break;
                case "11":
                    return LilleStraight(dC);
                    break;
                case "12":
                    return StorStraight(dC);
                    break;
                case "13":
                    return Chancen(dC);
                    break;
                case "14":
                    return Yatzy(dC);
                    break;
                default:
                    return 1000000;
                    break;
            }
        }
        public int Enere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    i++;
                }
            }
            return i;
        }
        public int Toere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 2)
                {
                    i++;
                }
            }
            return i * 2;
        }
        public int Treere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 3)
                {
                    i++;
                }
            }
            return i * 3;
        }
        public int Firere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 4)
                {
                    i++;
                }
            }
            return i * 4;
        }
        public int Femmere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 5)
                {
                    i++;
                }
            }
            return i * 5;
        }
        public int Seksere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 6)
                {
                    i++;
                }
            }
            return i * 6;
        }
        public int EtPar(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            int score4 = 0;
            int score5 = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                    if (enere > 1)
                    {
                        score1 = 2;
                    }
                }
                if (d.Eyes == 2)
                {
                    toere++;
                    if (toere > 1)
                    {
                        score2 = 4;
                    }
                }
                if (d.Eyes == 3)
                {
                    treere++;
                    if (treere > 1)
                    {
                        score3 = 6;
                    }
                }
                if (d.Eyes == 4)
                {
                    firere++;
                    if (firere > 1)
                    {
                        score4 = 8;
                    }
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                    if (femmere > 1)
                    {
                        score5 = 10;
                    }
                }
                if (d.Eyes == 6)
                {
                    seksere++;
                    if (seksere > 1)
                    {
                        return 12;
                    }
                }
            }
            if (score5 != 0) { return score5; }
            else if (score4 != 0) { return score4; }
            else if (score3 != 0) { return score3; }
            else if (score2 != 0) { return score2; }
            else if (score1 != 0) { return score1; }
            else { return 0; }
        }
        public int ToPar(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            int score4 = 0;
            int score5 = 0;
            int score6 = 0;
            int score = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                    if (enere > 1)
                    {
                        score1 = 2;
                    }
                }
                if (d.Eyes == 2)
                {
                    toere++;
                    if (toere > 1)
                    {
                        score2 = 4;
                    }
                }
                if (d.Eyes == 3)
                {
                    treere++;
                    if (treere > 1)
                    {
                        score3 = 6;
                    }
                }
                if (d.Eyes == 4)
                {
                    firere++;
                    if (firere > 1)
                    {
                        score4 = 8;
                    }
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                    if (femmere > 1)
                    {
                        score5 = 10;
                    }
                }
                if (d.Eyes == 6)
                {
                    seksere++;
                    if (seksere > 1)
                    {
                        score6 = 12;
                    }
                }
            }
            if (score6 != 0)
            {
                score = score6;
            }
            if (score5 != 0)
            {
                if (score != 0)
                {
                    return score + score5;
                }
                else
                {
                    score = score5;
                }
            }
            if (score4 != 0)
            {
                if (score != 0)
                {
                    return score + score4;
                }
                else
                {
                    score = score4;
                }
            }
            if (score3 != 0)
            {
                if (score != 0)
                {
                    return score + score3;
                }
                else
                {
                    score = score3;
                }
            }
            if (score2 != 0)
            {
                if (score != 0)
                {
                    return score + score2;
                }
                else
                {
                    score = score2;
                }
            }
            if (score1 != 0)
            {
                if (score != 0)
                {
                    return score + score1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public int TreEns(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                    if (enere > 2)
                    {
                        return enere;
                    }
                }
                if (d.Eyes == 2)
                {
                    toere++;
                    if (toere > 2)
                    {
                        return toere * 2;
                    }
                }
                if (d.Eyes == 3)
                {
                    treere++;
                    if (treere > 2)
                    {
                        return treere * 3;
                    }
                }
                if (d.Eyes == 4)
                {
                    firere++;
                    if (firere > 2)
                    {
                        return firere * 4;
                    }
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                    if (femmere > 2)
                    {
                        return femmere * 5;
                    }
                }
                if (d.Eyes == 6)
                {
                    seksere++;
                    if (seksere > 2)
                    {
                        return seksere * 6;
                    }
                }
            }
            return 0;
        }
        public int FireEns(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                    if (enere > 3)
                    {
                        return enere;
                    }
                }
                if (d.Eyes == 2)
                {
                    toere++;
                    if (toere > 3)
                    {
                        return toere * 2;
                    }
                }
                if (d.Eyes == 3)
                {
                    treere++;
                    if (treere > 3)
                    {
                        return treere * 3;
                    }
                }
                if (d.Eyes == 4)
                {
                    firere++;
                    if (firere > 3)
                    {
                        return firere * 4;
                    }
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                    if (femmere > 3)
                    {
                        return femmere * 5;
                    }
                }
                if (d.Eyes == 6)
                {
                    seksere++;
                    if (seksere > 3)
                    {
                        return seksere * 6;
                    }
                }
            }
            return 0;
        }
        public int LilleStraight(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            int score = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                }
                if (d.Eyes == 2)
                {
                    toere++;
                }
                if (d.Eyes == 3)
                {
                    treere++;
                }
                if (d.Eyes == 4)
                {
                    firere++;
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                }
            }
            if (enere != 0 && toere != 0 && treere != 0 && firere != 0 && femmere != 0)
            {
                return 15;
            }
            return 0;
        }
        public int StorStraight(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            int score = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                }
                if (d.Eyes == 2)
                {
                    toere++;
                }
                if (d.Eyes == 3)
                {
                    treere++;
                }
                if (d.Eyes == 4)
                {
                    firere++;
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                }
                if (d.Eyes == 6)
                {
                    seksere++;
                }
            }
            if (toere != 0 && treere != 0 && firere != 0 && femmere != 0 && seksere != 0)
            {
                return 20;
            }
            return 0;
        }
        public int Chancen(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                i = i + d.Eyes;
            }
            return i;
        }
        public int Yatzy(DieCup dC)
        {
            int i = dC.DieA[0].Eyes;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes != i)
                {
                    return 0;
                }
            }
            return 50;
        }
        public int NoOfPlayers(string s)
        {
            int i = 0;
            while (i < 1 || i > 5)
            {
                switch (s)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                        Console.Clear();
                        i = int.Parse(s);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Indtast et tal mellem 1 og 5.\n");
                        s = Console.ReadLine();
                        break;
                }
            }
            return i;
        }
        public Player[] CreatePlayers(int i)
        {                                // Metodetype: Player Array (hvilket vil sige metoden SKAL returne et player Array) - Tager int i (som er det antal spillere, der angives) som parameter.
            Player[] pA = new Player[i]; // Opretter nyt Player Array
            for (int j = i; j > 0; j--)  // Lad os sige vi har fået 4 ind som i. Sætter j = 4 og trækker 1 fra j hver gang løkken kører efter 1. run.
            {
                int k = i - j; // I første loop gennemgang bliver k = 4-4 = 0
                Console.WriteLine("Indtast et navn på mellem 3 og 9 tegn på spiller {0}:\n", (k + 1)); //Spørger om navn på spiller k + 1 = spiller 1
                pA[k] = new Player(); // Opretter en ny spiller på plads k = 0 i arrayet
                while (((pA[k]).Name).Length > 9 || ((pA[k]).Name).Length < 3) // Løkke der tjekker for længden af det indtastede navn.
                {                                                              // Ift. til at tegne scoreboardet senere, ville det være et problem, hvis folk indtaster ingenting eller 30 siders tekst.
                    Console.Clear();
                    Console.WriteLine("Indtast et navn på mellem 3 og 9 tegn:\n");
                    pA[k].Name = Console.ReadLine(); // Når navnet opfylder kriterierne, gives navnet til Player 0 i arrayet, whileløkken dør og koden fortsætter til næste Player.
                }                                    // j er nu 3 og k = i-j bliver 1, og vi kan derfor navngive Player 1 i arrayet nu i stedet for Player 0.
                Console.Clear();                     // For-løkken stopper når j ikke længere er større end 0, fordi vi så har navngivet det ønskede antal spillere.
            }
            return pA;
        }
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
                p.PrintProperty(p.ScoreArray[0], p.BoolArray[0]);
            }
            Console.Write("\n" + new string(' ', 40) + "2:  2’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[1], p.BoolArray[1]);
            }
            Console.Write("\n" + new string(' ', 40) + "3:  3’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[2], p.BoolArray[2]);
            }
            Console.Write("\n" + new string(' ', 40) + "4:  4’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[3], p.BoolArray[3]);
            }
            Console.Write("\n" + new string(' ', 40) + "5:  5’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[4], p.BoolArray[4]);
            }
            Console.Write("\n" + new string(' ', 40) + "6:  6’ere__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[5], p.BoolArray[5]);
            }
            Console.Write("\n" + new string(' ', 40) + "    Bonus__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.Bonus, p.FillerB);
            }
            Console.Write("\n" + new string(' ', 40) + "7:  Et par_________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[6], p.BoolArray[6]);
            }
            Console.Write("\n" + new string(' ', 40) + "8:  To par_________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[7], p.BoolArray[7]);
            }
            Console.Write("\n" + new string(' ', 40) + "9:  Tre ens________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[8], p.BoolArray[8]);
            }
            Console.Write("\n" + new string(' ', 40) + "10: Fire ens_______ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[9], p.BoolArray[9]);
            }
            Console.Write("\n" + new string(' ', 40) + "11: Lille Straight_ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[10], p.BoolArray[10]);
            }
            Console.Write("\n" + new string(' ', 40) + "12: Stor Straight__ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[11], p.BoolArray[11]);
            }
            Console.Write("\n" + new string(' ', 40) + "13: Chancen________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[12], p.BoolArray[12]);
            }
            Console.Write("\n" + new string(' ', 40) + "14: Yatzy__________ " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.ScoreArray[13], p.BoolArray[13]);
            }
            Console.Write("\n" + new string(' ', 60) + "| ");
            foreach (Player p in pA)
            {
                Console.Write(new string(' ', 10) + "| ");
            }
            Console.Write("\n" + new string(' ', 40) + "Samlet Score:       " + "| ");
            foreach (Player p in pA)
            {
                p.PrintProperty(p.TotalScore, p.FillerB);
            }
            Console.SetCursorPosition(0, 0);
        }
        public void PrintTurn(Player[] pA, Player p)
        {
            Console.Clear();
            PrintScoreCard(pA);
            Console.Write(p.Name + "s tur:\n\n");
        }
    }
}
