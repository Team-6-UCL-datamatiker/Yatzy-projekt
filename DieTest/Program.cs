namespace DieTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();

            int index = 0;
            while (index < 100)
            {
                die1.roll();
                //die1.freeze();
                Console.WriteLine(die1.getValue());
                index++;
            }
        }
    }
}
