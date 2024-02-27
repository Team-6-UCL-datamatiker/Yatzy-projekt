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
        private bool enere = false;
        public int Toere { get; set; }
        private bool toere = false;
        public int Treere { get; set; }
        private bool treere = false;
        public int Firere { get; set; }
        private bool firere = false;
        public int Femmere { get; set; }
        private bool femmere = false;
        public int Seksere { get; set; }
        private bool seksere = false;
        public int Bonus { get; set; }
        public int EtPar { get; set; }
        private bool etPar = false;
        public int ToPar { get; set; }
        private bool toPar = false;
        public int TreEns { get; set; }
        private bool treEns = false;
        public int FireEns { get; set; }
        private bool fireEns = false;
        public int LilleStraight { get; set; }
        private bool lilleStraight = false;
        public int StorStraight { get; set; }
        private bool storStraight = false;
        public int Chancen { get; set; }
        private bool chancen = false;
        public int Yatzy { get; set; }
        private bool yatzy = false;
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

        public void SetScore(string s, Die[] dA)
        {
            switch (s)
            {
                case "14":
                    if (yatzy == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                        //-------------------------------- tilbage
                    }
                    else
                    {
                        int i = dA[0].Eyes; 
                        foreach (Die d in dA)
                        {
                            if (d.Eyes != i)
                            {
                                Console.WriteLine("Du har ikke yatzy.\nTryk Enter for at sætte yatzy til 0 eller indtast \"hov\" for at vælge en anden kombination\n");
                                while (s != "")
                                {
                                    s = Console.ReadLine();
                                    if (s == "hov")
                                    {
                                        //-------------------------------- tilbage
                                        break;
                                    }
                                    else if (s != "")
                                    {
                                        Console.WriteLine("\"hov\" eller Enter, makker.\n");
                                    }
                                    else
                                    {
                                        Yatzy = 0;
                                        yatzy = true;
                                    }
                                }
                            }
                            else
                            {
                            }
                        }
                        
                        Console.WriteLine("Tryk Enter for at bekræfte yatzy til 50 point eller indtast \"hov\" for at vælge en anden kombination\n");
                        s = Console.ReadLine();
                        if (s == "hov")
                        {
                            //-------------------------------- tilbage
                            break;
                        }
                        else if (s != "")
                        {
                            Console.WriteLine("\"hov\" eller Enter, makker.\n");
                        }
                        else
                        {
                            Yatzy = 50;
                            yatzy = true;
                        }
                    }
                    break;


                case "13":
                    if (chancen == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "12":
                    if (storStraight == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "11":
                    if (lilleStraight == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "10":
                    if (fireEns == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "9":
                    if (treEns == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "8":
                    if (toPar == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "7":
                    if (etPar == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "6":
                    if (seksere == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "5":
                    if (femmere == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "4":
                    if (firere == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "3":
                    if (treere == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "2":
                    if (toere == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                case "1":
                    if (enere == true)
                    {
                        Console.WriteLine("Yatzy er allerede taget.\n");
                        Console.WriteLine("Vælg venligst en anden kombination.\n");
                    }
                    break;
                default:
                    break;
            }
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
