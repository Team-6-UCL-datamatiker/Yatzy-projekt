namespace DieTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Feltvariable:
            Tur t = new Tur();
            string genstart = "";

            //Velkomstbesked:
            Console.WriteLine("Velkommen til Raflebæger Simulator. Tryk på Enter for at starte.\n");
            Console.ReadLine();
            Console.Clear();

            //Løkke der starter turen og genstarter løkken, hvis spilleren vil spille igen:
            while (genstart != "q")
            {
                t.StartTur();
                Console.WriteLine("Tryk på Enter for at spille igen, eller tast \"q\" for at afslutte.\n");
                genstart = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
