namespace DieTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test program
            DieCup dieCup = new DieCup();

            int rollCount = 0;
            while (rollCount < 3)
            {

                Console.WriteLine("Rolls left: " + (3 - rollCount));
                Console.WriteLine("Press 1 to roll");
                while (true)
                {
                    try //handle crash for wron inputs
                    {
                        int input = int.Parse(Console.ReadLine());
                        Console.WriteLine("---------------");
                        if (input == 1) break;
                        else Console.WriteLine("Please press 1");
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("---------------");
                        Console.WriteLine("Please press 1");
                    }

                }

                dieCup.roll();
                dieCup.printResults();
                rollCount++;
                Console.WriteLine("---------------");

                //Freeze part
                Console.WriteLine("Press 1 to freeze die1, 2 to freeze die2 etc.");
                Console.WriteLine("Press q to confirm your choice");
                while (true)
                {

                    string input = Console.ReadLine();

                    if (input == "q") { break; }

                    switch (input)
                    {
                        case "q":
                            break;
                        case "1":
                            dieCup.lockDie(0);
                            Console.WriteLine("Die 1 locked!");
                            break;
                        case "2":
                            dieCup.lockDie(1);
                            Console.WriteLine("Die 2 locked!");
                            break;
                        case "3":
                            dieCup.lockDie(2);
                            Console.WriteLine("Die 3 locked!");
                            break;
                        case "4":
                            dieCup.lockDie(3);
                            Console.WriteLine("Die 4 locked!");
                            break;
                        case "5":
                            dieCup.lockDie(4);
                            Console.WriteLine("Die 5 locked!");
                            break;

                    }
                }
            }
        }
    }
}
