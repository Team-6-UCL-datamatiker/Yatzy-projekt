namespace DieTest
{
    public class Misc
    {

        public void Loading()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.CursorVisible = false;
                Console.Write("Loading");
                for (int j = 0; j < 3; j++)
                {
                    System.Threading.Thread.Sleep(500);
                    Console.Write(".");
                }
                System.Threading.Thread.Sleep(500);
                Console.Clear();

            }

            Console.CursorVisible = true;
        }
        public void Title()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __     __          _                 ");
            Console.WriteLine(" \\ \\   / /         | |                ");
            Console.WriteLine("  \\ \\_/ /    __ _  | |_   ____  _   _ ");
            Console.WriteLine("   \\   /    / _` | | __| |_  / | | | |");
            Console.WriteLine("    | |    | (_| | | |_   / /  | |_| |");
            Console.WriteLine("    |_|     \\__,_|  \\__| /___|  \\__, |");
            Console.WriteLine("                                 __/ |");
            Console.WriteLine("                                |___/ ");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" __     __          _                 ");
            Console.WriteLine(" \\ \\   / /         | |                ");
            Console.WriteLine("  \\ \\_/ /    __ _  | |_   ____  _   _ ");
            Console.WriteLine("   \\   /    / _` | | __| |_  / | | | |");
            Console.WriteLine("    | |    | (_| | | |_   / /  | |_| |");
            Console.WriteLine("    |_|     \\__,_|  \\__| /___|  \\__, |");
            Console.WriteLine("                                 __/ |");
            Console.WriteLine("                                |___/ ");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" __     __          _                 ");
            Console.WriteLine(" \\ \\   / /         | |                ");
            Console.WriteLine("  \\ \\_/ /    __ _  | |_   ____  _   _ ");
            Console.WriteLine("   \\   /    / _` | | __| |_  / | | | |");
            Console.WriteLine("    | |    | (_| | | |_   / /  | |_| |");
            Console.WriteLine("    |_|     \\__,_|  \\__| /___|  \\__, |");
            Console.WriteLine("                                 __/ |");
            Console.WriteLine("                                |___/ ");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" __     __          _                 ");
            Console.WriteLine(" \\ \\   / /         | |                ");
            Console.WriteLine("  \\ \\_/ /    __ _  | |_   ____  _   _ ");
            Console.WriteLine("   \\   /    / _` | | __| |_  / | | | |");
            Console.WriteLine("    | |    | (_| | | |_   / /  | |_| |");
            Console.WriteLine("    |_|     \\__,_|  \\__| /___|  \\__, |");
            Console.WriteLine("                                 __/ |");
            Console.WriteLine("                                |___/ ");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" __     __          _                 ");
            Console.WriteLine(" \\ \\   / /         | |                ");
            Console.WriteLine("  \\ \\_/ /    __ _  | |_   ____  _   _ ");
            Console.WriteLine("   \\   /    / _` | | __| |_  / | | | |");
            Console.WriteLine("    | |    | (_| | | |_   / /  | |_| |");
            Console.WriteLine("    |_|     \\__,_|  \\__| /___|  \\__, |");
            Console.WriteLine("                                 __/ |");
            Console.WriteLine("                                |___/ ");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" __     __          _                 ");
            Console.WriteLine(" \\ \\   / /         | |                ");
            Console.WriteLine("  \\ \\_/ /    __ _  | |_   ____  _   _ ");
            Console.WriteLine("   \\   /    / _` | | __| |_  / | | | |");
            Console.WriteLine("    | |    | (_| | | |_   / /  | |_| |");
            Console.WriteLine("    |_|     \\__,_|  \\__| /___|  \\__, |");
            Console.WriteLine("                                 __/ |");
            Console.WriteLine("                                |___/ ");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.ResetColor();
        }


    }
}
