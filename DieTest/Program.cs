namespace DieTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Feltvariable
            Tur s = new Tur();
            string genstart = "y";

            // Programkode:
            Console.WriteLine("Velkommen til Raflebæger Simulator. Tryk på Enter for at starte.");
            Console.ReadLine();
            Console.Clear();
            while (genstart == "y")
            {
                s.StartTur();
                Console.WriteLine("Tast \"y\" for at spille igen, eller tryk på Enter for at afslutte.");
                genstart = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
