using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Game
    {
        
        static void Main(string[] args)

        {
            DiceCup diceCup = new DiceCup();
            diceCup.Shake();
            
            Console.WriteLine("Hello, we are gonna play a little game to try and get 5 of the same dice rolls.");
            //System.Threading.Thread.Sleep(3000);
            Console.WriteLine("You have 3 rerolls, and you can lock dice you'd like to keep.");
            //System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Would you like to play? yes/no");
            string answ = Console.ReadLine();

            if (answ == "yes")
            {
                Console.Clear();
                diceCup.Shake();
                int dice1 = diceCup.die1;
                int dice2 = diceCup.die2;
                int dice3 = diceCup.die3;
                int dice4 = diceCup.die4;
                int dice5 = diceCup.die5;
                int rerolls = 2;            

                Console.WriteLine("| Die number: | Result: |");
                Console.WriteLine("|      1      |    " + dice1 + "    |");
                Console.WriteLine("|      2      |    " + dice2 + "    |");
                Console.WriteLine("|      3      |    " + dice3 + "    |");
                Console.WriteLine("|      4      |    " + dice4 + "    |");
                Console.WriteLine("|      5      |    " + dice5 + "    |");
                Console.WriteLine("Rerolls left: " + rerolls);

                if (dice1 == dice2 && dice1 == dice3 && dice1 == dice4 && dice1 == dice5)
                {
                    Console.WriteLine("Congrats!!!");
                }
                else
                {

                    Console.WriteLine("To lock dice, write 'Lock' followed by the number of the die you'd like to lock.");
                    Console.WriteLine("Otherwise, write 'Roll' to roll all again.");

                    string answ2 = Console.ReadLine();

                    if (answ2.Contains("Lock") == true)
                    {
                        diceCup.Shake();
                        if (answ2.Contains("1") == false)
                        {
                            dice1 = diceCup.die1;
                        }
                        if (answ2.Contains("2") == false)
                        {
                            dice2 = diceCup.die2;
                        }
                        if (answ2.Contains("3") == false)
                        {
                            dice3 = diceCup.die3;
                        }
                        if (answ2.Contains("4") == false)
                        {
                            dice4 = diceCup.die4;
                        }
                        if (answ2.Contains("5") == false)
                        {
                            dice5 = diceCup.die5;
                        }
                    }
                    if (answ2.Contains("Roll") == true)
                    {
                        diceCup.Shake();
                        dice1 = diceCup.die1;
                        dice2 = diceCup.die2;
                        dice3 = diceCup.die3;
                        dice4 = diceCup.die4;
                        dice5 = diceCup.die5;

                    }
                    Console.Clear();
                    Console.WriteLine("Rolling....");
                    rerolls = rerolls - 1;
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("| Die number: | Result: |");
                    Console.WriteLine("|      1      |    " + dice1 + "    |");
                    Console.WriteLine("|      2      |    " + dice2 + "    |");
                    Console.WriteLine("|      3      |    " + dice3 + "    |");
                    Console.WriteLine("|      4      |    " + dice4 + "    |");
                    Console.WriteLine("|      5      |    " + dice5 + "    |");
                    Console.WriteLine("Rerolls left: " + rerolls);

                    if (dice1 == dice2 && dice1 == dice3 && dice1 == dice4 && dice1 == dice5)
                    {
                        Console.WriteLine("Congrats!!!");
                    }
                    else
                    {
                        Console.WriteLine("To lock dice, write 'Lock' followed by the number of the die you'd like to lock.");
                        Console.WriteLine("Otherwise, write 'Roll' to roll all again.");

                        answ2 = Console.ReadLine();

                        if (answ2.Contains("Lock") == true)
                        {
                            diceCup.Shake();

                            if (answ2.Contains("1") == false)
                            {
                                dice1 = diceCup.die1;
                            }
                            if (answ2.Contains("2") == false)
                            {
                                dice2 = diceCup.die2;
                            }
                            if (answ2.Contains("3") == false)
                            {
                                dice3 = diceCup.die3;
                            }
                            if (answ2.Contains("4") == false)
                            {
                                dice4 = diceCup.die4;
                            }
                            if (answ2.Contains("5") == false)
                            {
                                dice5 = diceCup.die5;
                            }
                        }
                        if (answ2.Contains("Roll") == true)
                        {
                            diceCup.Shake();
                            dice1 = diceCup.die1;
                            dice2 = diceCup.die2;
                            dice3 = diceCup.die3;
                            dice4 = diceCup.die4;
                            dice5 = diceCup.die5;

                        }
                        Console.Clear();
                        Console.WriteLine("Rolling....");
                        rerolls = rerolls - 1;
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("| Die number: | Result: |");
                        Console.WriteLine("|      1      |    " + dice1 + "    |");
                        Console.WriteLine("|      2      |    " + dice2 + "    |");
                        Console.WriteLine("|      3      |    " + dice3 + "    |");
                        Console.WriteLine("|      4      |    " + dice4 + "    |");
                        Console.WriteLine("|      5      |    " + dice5 + "    |");
                        Console.WriteLine("Rerolls left: " + rerolls);

                        if (dice1 == dice2 && dice1 == dice3 && dice1 == dice4 && dice1 == dice5)
                        {
                            Console.WriteLine("Congrats!!!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, better luck next time.");
                        }
                    }
                }

            }
            if (answ == "no")
            {
                Console.WriteLine("Have a nice day then!");
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }


            //int index = 0;
            //while (index < 100)
            //{
            //    die1.roll();
            //    die1.freeze();
            //    Console.WriteLine(die1.getValue());
            //    index++;
            //}


        }




    }
}
