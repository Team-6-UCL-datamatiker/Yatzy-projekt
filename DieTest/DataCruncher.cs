using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DieTest
{
    internal class DataCruncher
    {
        // Farveordbog
        Dictionary<string, ConsoleColor> colors = new Dictionary<string, ConsoleColor>()
        {{"rod", ConsoleColor.DarkRed}, {"rods", ConsoleColor.Red}, {"blå", ConsoleColor.DarkBlue}, {"blås", ConsoleColor.Blue}, {"gron", ConsoleColor.DarkGreen}, {"grons", ConsoleColor.Green}, {"turkis", ConsoleColor.DarkCyan}, {"turkiss", ConsoleColor.Cyan}, {"lilla", ConsoleColor.DarkMagenta}, {"lillas", ConsoleColor.Magenta}};

        // Metoder:
        // Spilleroprettelse:
        public Player[] CreateNumberOfPlayers()
        {
            TypeLine("Velkommen til Yatzy.\n");
            TypeLine("\nIndtast antallet af spillere (1-5).\n\n");
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
                        TypeLine("Indtast et tal mellem 1 og 5.\n\n");
                        sDeclaredPlayers = Console.ReadLine();
                        break;
                }
            }
            Player[] playerArray = new Player[iNumberOfPlayers];
            for (int i = iNumberOfPlayers; i > 0; i--)
            {
                TypeLine("Spiller");
                Console.Write("{0}: ", iNumberOfPlayers - i + 1);
                string sName = Console.ReadLine();
                while (sName.Length > 9 || sName.Length < 3)
                {
                    Console.Clear();
                    TypeLine("Indtast et navn på mellem 3 og 9 tegn, spiller ");
                    Console.WriteLine("{0}:\n", iNumberOfPlayers - i + 1);
                    sName = Console.ReadLine();
                }
                string sColor = "";
                string sSecondaryColor = "";
                bool bWhile = true;
                do
                {
                    Console.Clear();
                    Encoding originalEncoding = Console.OutputEncoding;
                    Console.OutputEncoding = Encoding.UTF8;
                    TypeLine("Hyggeligt at møde dig");
                    Thread.Sleep(500);
                    TypeLine(", " + sName);
                    Thread.Sleep(500);
                    TypeLine("\n\nKunne du tænke dig at være rød, blå, grøn, lilla eller turkis?\n\n");
                    Console.OutputEncoding = originalEncoding;
                    sColor = Console.ReadLine();
                    bWhile = false;
                    switch (sColor)
                    {
                        case "blå":
                            sSecondaryColor = "blås";
                            break;
                        case "turkis":
                            sSecondaryColor = "turkiss";
                            break;
                        case "gron":
                            sSecondaryColor = "grons";
                            break;
                        case "lilla":
                            sSecondaryColor = "lillas";
                            break;
                        case "rod":
                            sSecondaryColor = "rods";
                            break;
                        default:
                            bWhile = true;
                            break;
                    }
                }
                while (bWhile == true);
                Console.Clear();
                if (sColor == "rod")
                { 
                    TypeLine("Fortræffeligt valg");
                    Thread.Sleep(500);
                    TypeLine(", " + sName + "!");
                    Thread.Sleep(500);
                    TypeLine(" Den bedste farve!");
                    Thread.Sleep(2500);
                }
                else
                {
                    TypeLine("Hmm");
                    Thread.Sleep(500);
                    TypeLine(", okay " + sName);
                    Thread.Sleep(500);
                    TypeLine(", interessant valg...");
                    Thread.Sleep(2500);
                }
                playerArray[iNumberOfPlayers - i] = new Player(sName, sColor, sSecondaryColor);
                Console.Clear();
            }
            return playerArray;
        }

        // Scoreberegning:
        private static int OnesToSixes(string sOneToSix, int[] dieArrayEyes)
        {
            int sum = 0;
            int oneToSix = int.Parse(sOneToSix);

            foreach (int i in dieArrayEyes)
            {
                if (i == oneToSix)
                {
                    sum += i;
                }
            }
            return sum;
        }
        private static int Pair(int[] dieArrayEyes)
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
        private static int TwoPairs(int[] dieArrayEyes)
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
        }
        private static int ThreeOfAKind(int[] dieArrayEyes)
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
        }
        private static int FourOfAKind(int[] dieArrayEyes)
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
        private static int SmallStraight(int[] dieArrayEyes)
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
        private static int BigStraight(int[] dieArrayEyes)
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
        private static int Chance(int[] dieArrayEyes)
        {
            int sum = 0;
            foreach (int Eyes in dieArrayEyes)
            {
                sum += Eyes;
            }
            return sum;
        }
        private static int Yatzy(int[] dieArrayEyes)
        {
            int iEyes = dieArrayEyes[0];
            foreach (int i in dieArrayEyes)
            {
                if (dieArrayEyes[i] != iEyes)
                {
                    return 0;
                }
            }
            return 50;
        }
        private static int CalculateSpecifiedScore(DieCup dieCup, string sScoreIdentifier)
        {
            int[] dieArrayEyes = dieCup.GetDiceValues();
            switch (sScoreIdentifier)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                    return OnesToSixes(sScoreIdentifier, dieArrayEyes);
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
                    return Yatzy(dieArrayEyes);
                default:
                    return 1000000;
            }
        }
        private static void CalculateBonus(Player player)
        {
            if (player.ScoreArray[14] == 0 && player.ScoreArray[0] + player.ScoreArray[1] + player.ScoreArray[2] + player.ScoreArray[3] + player.ScoreArray[4] + player.ScoreArray[5] >= 63)
            {
                player.ScoreArray[14] = 50;
                player.ScoreArray[15] += player.ScoreArray[14];
            }
        }

        // Scoreopdatering:
        public void SetScoreSorter(DieCup dieCup, Player player, Player[] playerArray, int iRunde, int iRollCounter)
        {
            bool bStayinWhile = true;
            while (bStayinWhile == true)
            {
                PrintTurn(dieCup, player, playerArray, iRunde, iRollCounter);
                Console.Write("\n\n\n\n\n\n\n\n\n\nIndtast et tal mellem 1 og 14 for at vælge kombination: ");
                string sScoreIdentifier = Console.ReadLine();
                string sScoreNavn;
                bStayinWhile = false;
                switch (sScoreIdentifier)
                {
                    case "1":
                        sScoreNavn = "1'ere";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        CalculateBonus(player);
                        break;
                    case "2":
                        sScoreNavn = "2'ere";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        CalculateBonus(player);
                        break;
                    case "3":
                        sScoreNavn = "3'ere";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        CalculateBonus(player);
                        break;
                    case "4":
                        sScoreNavn = "4'ere";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        CalculateBonus(player);
                        break;
                    case "5":
                        sScoreNavn = "5'ere";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        CalculateBonus(player);
                        break;
                    case "6":
                        sScoreNavn = "6'ere";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        CalculateBonus(player);
                        break;
                    case "7":
                        sScoreNavn = "Et par";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        break;
                    case "8":
                        sScoreNavn = "To par";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        break;
                    case "9":
                        sScoreNavn = "Tre ens";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        break;
                    case "10":
                        sScoreNavn = "Fire ens";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        break;
                    case "11":
                        sScoreNavn = "Lille straight";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        break;
                    case "12":
                        sScoreNavn = "Stor straight";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        break;
                    case "13":
                        sScoreNavn = "Chancen";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        break;
                    case "14":
                        sScoreNavn = "Yatzy";
                        bStayinWhile = SetScore(sScoreIdentifier, sScoreNavn, bStayinWhile, dieCup, player);
                        break;
                    default:
                        bStayinWhile = true;
                        break;
                }

            }
            Console.Clear();
        }
        private static bool SetScore(string sScoreIdentifier, string scoreName, bool bStayInWhile, DieCup dieCup, Player player)
        {
            int iScoreIdentifier = int.Parse(sScoreIdentifier) - 1;
            if (player.BoolArray[iScoreIdentifier] == true)
            {
                Console.WriteLine("\nDu har allerede valgt {0}", scoreName);
                bStayInWhile = true;
            }
            else
            {
                Console.Write("\nDin {0} score er {1}. \n\nTryk Enter for at bekræfte eller indtast \"hov\" for at vælge en anden kombination: ", scoreName, CalculateSpecifiedScore(dieCup, sScoreIdentifier));
                while (true)
                {
                    string a = Console.ReadLine();
                    if (a == "hov")
                    {
                        bStayInWhile = true;
                        break;
                    }
                    else if (a != "")
                    {
                        TypeLine("\n\"hov\" eller Enter");
                        Thread.Sleep(500);
                        TypeLine(", makker.\n\n");
                    }
                    else
                    {
                        player.ScoreArray[iScoreIdentifier] = CalculateSpecifiedScore(dieCup, sScoreIdentifier);
                        player.BoolArray[iScoreIdentifier] = true;
                        player.ScoreArray[15] += player.ScoreArray[iScoreIdentifier];
                        break;
                    }
                }
            }
            return bStayInWhile;
        }

        // Printere:
        private void PrintName(Player player)
        {
            int iSpace = 10 - player.Name.Length;
            int iHalfSpace = iSpace / 2;
            int iModuloSpace = iSpace % 2;
            Console.BackgroundColor = colors.GetValueOrDefault(player.Color, ConsoleColor.Black);
            Console.Write(new string(' ', iHalfSpace + 1) + player.Name + new string(' ', iHalfSpace + iModuloSpace));
            Console.BackgroundColor = ConsoleColor.Black;
        }
        private static void PrintIsFrozen(Die die)
        {
            if (die.IsFrozen == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        public void PrintTurn(DieCup dieCup, Player player, Player[] playerArray, int iStringParameter, int iTurnMinusOne)
        {
            Console.Clear();
            PrintScoreCard(playerArray);
            Console.WriteLine("Runde {0}\n", iStringParameter + 1);
            Console.Write(player.Name + "s tur:\n\n");
            Console.WriteLine((iTurnMinusOne + 1) + ". Kast\n");
            foreach (Die die in dieCup.DieArray)
            {
                Console.Write("Terning " + (Array.IndexOf(dieCup.DieArray, die) + 1) + ": ");
                PrintIsFrozen(die);
                Console.WriteLine(die.Eyes);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        private void PrintSpecifiedScore(int iScore, bool bScore, Player player, int row)
        {
            if (row % 2 != 0)
            {
                Console.BackgroundColor = colors.GetValueOrDefault(player.Color, ConsoleColor.Black);
            }
            else
            {
                Console.BackgroundColor = colors.GetValueOrDefault(player.SecondaryColor, ConsoleColor.Black);
            }

            if (bScore == true)
            {
                int iSpace = 10 - (iScore.ToString()).Length;
                int iHalfSpace = iSpace / 2;
                int iModuloSpace = iSpace % 2;
                Console.Write(new string(' ', iHalfSpace) + "[" + iScore + "]" + new string(' ', iHalfSpace + iModuloSpace - 1));
            }
            else
            {
                int iSpace = 10 - (iScore.ToString()).Length;
                int iHalfSpace = iSpace / 2;
                int iModuloSpace = iSpace % 2;
                Console.Write(new string(' ', iHalfSpace) + " " + iScore + " " + new string(' ', iHalfSpace + iModuloSpace - 1));
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void PrintScoreCard(Player[] playerArray)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(new string(' ', 40) + "Spillere:          ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintName(player);
            }
            Console.Write("\n" + new string(' ', 40));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(new string(' ', 19));
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                Console.BackgroundColor = colors.GetValueOrDefault(player.SecondaryColor, ConsoleColor.Black);
                Console.Write(new string(' ', 11));
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n" + new string(' ', 40) + "1:  1’ere          ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[0], player.BoolArray[0], player, 3);
            }
            Console.Write("\n" + new string(' ', 40));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("2:  2’ere          ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[1], player.BoolArray[1], player, 4);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n" + new string(' ', 40) + "3:  3’ere          ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[2], player.BoolArray[2], player, 5);
            }
            Console.Write("\n" + new string(' ', 40));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("4:  4’ere          ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[3], player.BoolArray[3], player, 6);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n" + new string(' ', 40) + "5:  5’ere          ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[4], player.BoolArray[4], player, 7);
            }
            Console.Write("\n" + new string(' ', 40));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("6:  6’ere          ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[5], player.BoolArray[5], player, 8);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n" + new string(' ', 40) + "    Bonus          ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[14], player.BoolArray[14], player, 9);
            }
            Console.Write("\n" + new string(' ', 40));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("7:  Et par         ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[6], player.BoolArray[6], player, 10);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n" + new string(' ', 40) + "8:  To par         ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[7], player.BoolArray[7], player, 11);
            }
            Console.Write("\n" + new string(' ', 40));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("9:  Tre ens        ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[8], player.BoolArray[8], player, 12);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n" + new string(' ', 40) + "10: Fire ens       ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[9], player.BoolArray[9], player, 13);
            }
            Console.Write("\n" + new string(' ', 40));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("11: Lille Straight ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[10], player.BoolArray[10], player, 14);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n" + new string(' ', 40) + "12: Stor Straight  ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[11], player.BoolArray[11], player, 15);
            }
            Console.Write("\n" + new string(' ', 40));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("13: Chancen        ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[12], player.BoolArray[12], player, 16);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n" + new string(' ', 40) + "14: Yatzy          ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[13], player.BoolArray[13], player, 17);
            }
            Console.Write("\n" + new string(' ', 40));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("    Samlet Score   ");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (Player player in playerArray)
            {
                PrintSpecifiedScore(player.ScoreArray[15], player.BoolArray[15], player, 18);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.SetCursorPosition(0, 0);
        }
        public void PrintWinner(Player[] playerArray)
        {
            int v = 0;
            Player winner = new Player("vinder", "blå", "blås");
            foreach (Player p in playerArray)
            {
                if (p.ScoreArray[15] > v)
                {
                    v = p.ScoreArray[15];
                    winner = p;
                }
            }
            Console.Clear();
            PrintScoreCard(playerArray);
            Console.WriteLine(winner.Name + " VINDER MED " + v + " POINT!");
            Thread.Sleep(1500);
            Console.SetCursorPosition(0, 2);
            Random r = new Random();
            for (int j = 0; j < 60; j++)
            {
                Thread.Sleep(500);
                Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                Console.BackgroundColor = (ConsoleColor)r.Next(0, 16);
                Console.WriteLine(new string(' ', j * j) + "HAHAHA TABERE!");
            }
            Console.ReadLine();
        }
        public void PrintFlowController(int iWriteIdentifier)
        {
            switch (iWriteIdentifier)
            {
                case 1:
                    Console.WriteLine("Tryk på Enter for at rafle.\n");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\nRafle rafle rafle...\n");
                    Console.SetCursorPosition(0, 0);
                    Thread.Sleep(75);
                    Console.SetCursorPosition(0, 0);
                    break;
                case 3:
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\nIndtast numrene på de terninger, du vil låse (op), eller tryk på Enter for at rafle.\n");
                    break;
                case 4:
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    break;
                default:
                    break;
            }
        }
        public void PrintFlowController(int iWriteIdentifier, Player[] playerArray, Player player, int iStringParameter, DieCup dieCup)
        {
            switch (iWriteIdentifier)
            {
                case 1:
                    dieCup.UnFreezeAllDice();
                    Console.Clear();
                    PrintScoreCard(playerArray);
                    Console.WriteLine("Runde {0}\n", iStringParameter + 1);
                    Console.Write(player.Name + "s tur:\n\n");
                    break;
                default:
                    break;
            }
        }
        // Jeppes printanimation:
        private static void TypeLine(string line)
        {
            foreach (char c in line)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}
