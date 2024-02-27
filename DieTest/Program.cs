namespace DieTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Scoreboard scoreboard = new Scoreboard();
            //int[] values = { 4, 5, 4, 5, 2 };

            int numberOfPlayers;
            Console.WriteLine("Welome to yatzy!");
            Console.Write("How many players? ");
            while (true)
            {
                try
                {
                    numberOfPlayers = int.Parse(Console.ReadLine());
                    if (numberOfPlayers >= 2 && numberOfPlayers <= 5) { break; }
                    else { Console.WriteLine("Please type a number between 2 and 5"); }
                }
                catch (FormatException e) { Console.WriteLine("Enter a number between 2 and 5"); }
            }

            YatzyGame game = new YatzyGame(numberOfPlayers);
            game.startGame();

        }
    }
}
