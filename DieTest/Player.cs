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
        public bool EnereB { get; set; }
        public int Toere { get; set; }
        public bool ToereB { get; set; }
        public int Treere { get; set; }
        public bool TreereB { get; set; }
        public int Firere { get; set; }
        public bool FirereB { get; set; }
        public int Femmere { get; set; }
        public bool FemmereB { get; set; }
        public int Seksere { get; set; }
        public bool SeksereB { get; set; }
        public int Bonus { get; set; }
        public int EtPar { get; set; }
        public bool EtParB { get; set; }
        public int ToPar { get; set; }
        public bool ToParB { get; set; }
        public int TreEns { get; set; }
        public bool TreEnsB { get; set; }
        public int FireEns { get; set; }
        public bool FireEnsB { get; set; }
        public int LilleStraight { get; set; }
        public bool LilleStraightB { get; set; }
        public int StorStraight { get; set; }
        public bool StorStraightB { get; set; }
        public int Chancen { get; set; }
        public bool ChancenB { get; set; }
        public int Yatzy { get; set; }
        public bool YatzyB { get; set; }
        public int TotalScore { get; set; }
        public bool BlankB { get; set; }
        
        public Player()
        {
            Name = Console.ReadLine();
        }
        
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
            if (Enere + Toere + Treere + Firere + Femmere + Seksere >= 63 && Bonus == 0)
            {
                Bonus = 50;
                TotalScore = TotalScore + Bonus;
            }
        }
        public void SetScore(DieCup dC)
        {
            Calculator c = new Calculator();
            bool b = true;
            do
            {
                Console.Write("\nIndtast et tal mellem 1 og 14 for at vælge kombination: ");
                string s = Console.ReadLine();
                b = true;
                switch (s)
                {
                    case "1":
                        if (EnereB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt 1'ere");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin 1'ere score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.Enere(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    Enere = c.Enere(dC);
                                    EnereB = true;
                                    CalculateBonus();
                                    TotalScore = TotalScore + Enere;
                                    break;
                                }
                            }
                        }
                        break;
                    case "2":
                        if (ToereB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt 2'ere");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin 2'ere score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.Toere(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    Toere = c.Toere(dC);
                                    ToereB = true;
                                    CalculateBonus();
                                    TotalScore = TotalScore + Toere;
                                    break;
                                }
                            }
                        }
                        break;
                    case "3":
                        if (TreereB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt 3'ere");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin 3'ere score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.Treere(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    Treere = c.Treere(dC);
                                    TreereB = true;
                                    CalculateBonus();
                                    TotalScore = TotalScore + Treere;
                                    break;
                                }
                            }
                        }
                        break;
                    case "4":
                        if (FirereB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt 4'ere");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin 4'ere score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.Firere(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    Firere = c.Firere(dC);
                                    FirereB = true;
                                    CalculateBonus();
                                    TotalScore = TotalScore + Firere;
                                    break;
                                }
                            }
                        }
                        break;
                    case "5":
                        if (FemmereB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt 5'ere");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin 5'ere score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.Femmere(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    Femmere = c.Femmere(dC);
                                    FemmereB = true;
                                    CalculateBonus();
                                    TotalScore = TotalScore + Femmere;
                                    break;
                                }
                            }
                        }
                        break;
                    case "6":
                        if (SeksereB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt 6'ere");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin 6'ere score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.Seksere(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    Seksere = c.Seksere(dC);
                                    SeksereB = true;
                                    CalculateBonus();
                                    TotalScore = TotalScore + Seksere;
                                    break;
                                }
                            }
                        }
                        break;
                    case "7":
                        if (EtParB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt Et par");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin Et par score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.EtPar(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    EtPar = c.EtPar(dC);
                                    EtParB = true;
                                    TotalScore = TotalScore + EtPar;
                                    break;
                                }
                            }
                        }
                        break;
                    case "8":
                        if (ToParB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt To par");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin To par score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.ToPar(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    ToPar = c.ToPar(dC);
                                    ToParB = true;
                                    TotalScore = TotalScore + ToPar;
                                    break;
                                }
                            }
                        }
                        break;
                    case "9":
                        if (TreEnsB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt Tre ens");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin Tre ens score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.TreEns(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    TreEns = c.TreEns(dC);
                                    TreEnsB = true;
                                    TotalScore = TotalScore + TreEns;
                                    break;
                                }
                            }
                        }
                        break;
                    case "10":
                        if (FireEnsB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt Fire ens");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin Fire ens score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.FireEns(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    FireEns = c.FireEns(dC);
                                    FireEnsB = true;
                                    TotalScore = TotalScore + FireEns;
                                    break;
                                }
                            }
                        }
                        break;
                    case "11":
                        if (LilleStraightB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt Lille straight");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin Lille Straight score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.LilleStraight(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    LilleStraight = c.LilleStraight(dC);
                                    LilleStraightB = true;
                                    TotalScore = TotalScore + LilleStraight;
                                    break;
                                }
                            }
                        }
                        break;
                    case "12":
                        if (StorStraightB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt Stor straight");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin Stor Straight score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.StorStraight(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    StorStraight = c.StorStraight(dC);
                                    StorStraightB = true;
                                    TotalScore = TotalScore + StorStraight;
                                    break;
                                }
                            }
                        }
                        break;
                    case "13":
                        if (ChancenB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt Chancen.");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin Chancen score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.Chancen(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    Chancen = c.Chancen(dC);
                                    ChancenB = true;
                                    TotalScore = TotalScore + Chancen;
                                    break;
                                }
                            }
                        }
                        break;
                    case "14":
                        if (YatzyB == true)
                        {
                            Console.WriteLine("\nDu har allerede valgt Yatzy.");
                            b = false;
                        }
                        else
                        {
                            Console.Write("\nDin Yatzy score er {0}. \n\nTryk Enter for at bekræfte eller indtast \"hov vent\" for at vælge en anden kombination: ", c.Yatzy(dC));
                            while (true)
                            {
                                s = Console.ReadLine();
                                if (s == "hov vent")
                                {
                                    b = false;
                                    break;
                                }
                                else if (s != "")
                                {
                                    Console.WriteLine("\n\"hov vent\" eller Enter, makker.\n");
                                }
                                else
                                {
                                    Yatzy = c.Yatzy(dC);
                                    YatzyB = true;
                                    TotalScore = TotalScore + Yatzy;
                                    break;
                                }
                            }
                        }
                        break;
                    default:
                        b = false;
                        break;
                }
            } while (b == false);
        }
    }
}
