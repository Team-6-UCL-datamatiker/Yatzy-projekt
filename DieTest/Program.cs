namespace DieTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lokale variable:
            //
            int genstart = 0;
            DataCruncher crunch = new DataCruncher();

            //Intro:
            //
            Console.WriteLine("Velkommen til Yatzy.");
            Console.WriteLine("\nIndtast antallet af spillere (1-5).\n");
            int iPlayers = crunch.NoOfPlayers(Console.ReadLine());
            Player[] pArray = crunch.CreatePlayers(iPlayers);

            //Løkke der kører 14 runder af spillet:
            //
            while (genstart < 1)
            {
                genstart++;
                Console.WriteLine("Get ready for round {0}\n", genstart);
                Thread.Sleep(2000);

                // Foreach-løkken sørger for at alle spillere får en tur hver af de 14 runder:
                //
                foreach (Player p in pArray)
                {
                    // Lokale variable for metoden:
                    //
                    DieCup dc1 = new DieCup();
                    int i = 0;
                    string s = "";

                    // Starter den enkelte spillers tur:
                    //
                    crunch.PrintTurn(pArray, p);
                    Console.WriteLine("Tryk på Enter for at rafle.\n");
                    Console.ReadLine();

                    // While-løkken styrer de 3 kast med terningen:
                    //
                    while (i < 3)
                    {
                        // Rafleanimation:
                        //
                        for (int j = 0; j < 20; j++)
                        {
                            dc1.Roll();
                            crunch.PrintTurn(pArray, p);
                            crunch.PrintDieEyes(i, dc1);
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\nRafle rafle rafle...\n");
                            Console.SetCursorPosition(0, 0);
                            Thread.Sleep(75);
                            Console.SetCursorPosition(0, 0);
                        }
                        dc1.Roll();
                        crunch.PrintTurn(pArray, p);
                        crunch.PrintDieEyes(i, dc1);

                        // If else-løkken ændrer, hvad der sker efter det sidste kast:
                        //
                        if (i < 2)
                        {
                            s = "a";
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\nIndtast numrene på de terninger, du vil låse (op), eller tryk på Enter for at rafle.\n");
                            while (s != "")
                            {
                                s = Console.ReadLine();
                                dc1.FreezeMultipleDice(s);
                                crunch.PrintTurn(pArray, p);
                                crunch.PrintDieEyes(i, dc1);
                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\nIndtast numrene på de terninger, du vil låse (op), eller tryk på Enter for at rafle.\n");
                            }
                        }
                        else
                        {
                            dc1.FreezeAllDice();
                            crunch.PrintTurn(pArray, p);
                            crunch.PrintDieEyes(i, dc1);
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                            crunch.SetScoreSorter(dc1, p);
                            Console.Clear();
                            crunch.PrintScoreCard(pArray);
                        }
                        i++;
                    }
                }
                crunch.PrintScoreCard(pArray);
            }
            
            // Vinderanimation:
            //
            int v = 0;
            Player winner = new Player();
            foreach (Player p in pArray)
            {
                if (p.ScoreArray[15] > v)
                {
                    v = p.ScoreArray[15];
                    winner = p;
                }
            }
            Console.Clear();
            crunch.PrintScoreCard(pArray);
            Console.WriteLine(winner.Name + " VINDER MED " + v + " POINT!");
            Thread.Sleep(1500);
            Console.SetCursorPosition(0, 2);
            Random r = new Random();
            for (int j = 0; j < 200; j++)
            {
                Thread.Sleep(500);
                Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                Console.BackgroundColor = (ConsoleColor)r.Next(0, 16);
                Console.WriteLine(new string(' ', j * 3) + "HAHAHA TABERE!");
            }
            Console.ReadLine();
        }
    }
}
