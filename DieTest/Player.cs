using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Player
    {
        public Dictionary<string, int> scores = new Dictionary<string, int>();
        private Dictionary<string, bool> scoresModified = new Dictionary<string, bool>();
        public string name;
        public int number;

        public Player(string playerName, int playerNumber)
        
        {

            name = playerName;
            number = playerNumber;
            scores.Add("1'ere", 0);
            scores.Add("2'ere", 0);
            scores.Add("3'ere", 0);
            scores.Add("4'ere", 0);
            scores.Add("5'ere", 0);
            scores.Add("6'ere", 0);
            scores.Add("Et par", 0);
            scores.Add("To par", 0);
            scores.Add("Tre ens", 0);
            scores.Add("Fire ens", 0);
            scores.Add("Lille Straight", 0);
            scores.Add("Store Straight", 0);
            scores.Add("Chancen", 0);
            scores.Add("Yatzy", 0);

            scoresModified.Add("1'ere", false);
            scoresModified.Add("2'ere", false);
            scoresModified.Add("3'ere", false);
            scoresModified.Add("4'ere", false);
            scoresModified.Add("5'ere", false);
            scoresModified.Add("6'ere", false);
            scoresModified.Add("Et par", false);
            scoresModified.Add("To par", false);
            scoresModified.Add("Tre ens", false);
            scoresModified.Add("Fire ens", false);
            scoresModified.Add("Lille Straight", false);
            scoresModified.Add("Store Straight", false);
            scoresModified.Add("Chancen", false);
            scoresModified.Add("Yatzy", false);

        }
        public void SetScore(string slot, int value)
        {
            if (!scoresModified[slot])
            {
                scores[slot] = value;
                scoresModified[slot] = true; 
            }
            else
            {
                Console.WriteLine($"Score in slot '{slot}' has already been modified and cannot be changed again.");
            }
        }
        public int GetScore(string slot)
        {
            return scores[slot];
        }



    }

}
