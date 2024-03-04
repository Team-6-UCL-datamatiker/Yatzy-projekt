namespace DieTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiering
            DataCruncher crunch = new DataCruncher();
            DieCup dieCup = new DieCup();

            crunch.PrintTitle();

            Player[] playerArray = crunch.CreateNumberOfPlayers();

            //Løkke der kører 14 runder af spillet:
            for (int iRunde = 0; iRunde < 14; iRunde++)
            {
                // Alle får en tur hver af de 14 runder:
                foreach (Player player in playerArray)
                {
                    crunch.PrintFlowController(1, playerArray, player, iRunde, dieCup);
                    crunch.PrintFlowController(1);
                    
                    // For-løkken styrer de 3 kast med terningen:
                    for (int iRollCounter = 0; iRollCounter < 3; iRollCounter++)
                    {
                        // Rafleanimation:
                        for (int i = 0; i < 20; i++)
                        {
                            dieCup.Roll();
                            crunch.PrintTurn(dieCup, player, playerArray, iRunde, iRollCounter);
                            crunch.PrintFlowController(2);
                        }
                        dieCup.Roll();
                        crunch.PrintTurn(dieCup, player, playerArray, iRunde, iRollCounter);

                        // If'en styrer de første 2 kast med terningerne:
                        if (iRollCounter < 2)
                        {
                            crunch.PrintFlowController(3);
                            string sStrengMedIndhold = "abc";
                            while (sStrengMedIndhold != "")
                            {
                                sStrengMedIndhold = Console.ReadLine();
                                dieCup.FreezeMultipleDice(sStrengMedIndhold);
                                crunch.PrintTurn(dieCup, player, playerArray, iRunde, iRollCounter);
                                crunch.PrintFlowController(3);
                            }
                        }
                        // Else'en registrerer score i scoreboard:
                        else
                        {
                            dieCup.FreezeAllDice();
                            crunch.PrintTurn(dieCup, player, playerArray, iRunde, iRollCounter);
                            crunch.SetScoreSorter(dieCup, player, playerArray, iRunde, iRollCounter);
                            crunch.PrintScoreCard(playerArray);
                        }
                    }
                }
                crunch.PrintFlowController(4);
                crunch.PrintScoreCard(playerArray);
            }
            // Vinderanimation:
            crunch.PrintEndGame(playerArray);
        }
    }
}
