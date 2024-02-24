namespace DieTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Feltvariable:
            Tur t = new Tur();
            string genstart = "y";

            //Velkomstbesked:
            Console.WriteLine("Velkommen til Raflebæger Simulator. Tryk på Enter for at starte.");
            Console.ReadLine();
            Console.Clear();

            //Løkke der starter turen og genstarter løkken, hvis spilleren vil spille igen:
            while (genstart == "y")
            {
                t.StartTur();
                Console.WriteLine("Tast \"y\" for at spille igen, eller tryk på Enter for at afslutte.");
                genstart = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
