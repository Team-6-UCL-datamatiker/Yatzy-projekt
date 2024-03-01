namespace DieTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor(); //Reset color before game starts
           
            int numberOfPlayers;

            TypeLine("Welome to yatzy! \n");
            TypeLine("How many players? ");

            while (true) //Takes input from player (must be between 2 and 5)
            {
                try
                {
                    numberOfPlayers = int.Parse(Console.ReadLine());
                    if (numberOfPlayers >= 2 && numberOfPlayers <= 5) { break; }
                    else { Console.WriteLine("Please type a number between 2 and 5"); }
                }
                catch (FormatException e) { Console.WriteLine("Enter a number between 2 and 5"); }
            }

            //Make a new game with the specified amount of players
            YatzyGame game = new YatzyGame(numberOfPlayers);
            game.StartGame();

        }

        //Typing animation
        public static void TypeLine(string line)
        {
            foreach (char c in line)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}
