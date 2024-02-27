using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Scoreboard
    {
        private int[] scores;
        private bool[] catagoryUpdated;
        private string[] catagoryNames = { "Ones", "Twos", "Threes", "Fours", "Fives", "Sixes", "Pair", "Two Pairs", "Three of a kind", "Four of a kind", "Small Straight", "Big Straight", "Chance", "Yatzy" };
        private int totalScore = 0;

        public Scoreboard()
        {
            this.scores = new int[catagoryNames.Length];
            this.catagoryUpdated = new bool[catagoryNames.Length];


        }

        public void setScore(string catagory, int[] diceValues)
        {
            int index = Array.IndexOf(this.catagoryNames, catagory); //the index of the selected catagory in the catagory array. retuns -1 if not found

            if (index != -1 && this.catagoryUpdated[index] == false)
            {
                switch (catagory)
                {
                    case "Ones":
                        this.scores[index] = calculateOnesToSixes(1, diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Twos":
                        this.scores[index] = calculateOnesToSixes(2, diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Threes":
                        this.scores[index] = calculateOnesToSixes(3, diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Fours":
                        this.scores[index] = calculateOnesToSixes(4, diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Fives":
                        this.scores[index] = calculateOnesToSixes(5, diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Sixes":
                        this.scores[index] = calculateOnesToSixes(6, diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Pair":
                        this.scores[index] = calculatePair(diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Two Pairs":
                        this.scores[index] = calculateTwoPairs(diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Three of a kind":
                        this.scores[index] = calculateTreeOfAKind(diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Four of a kind":
                        this.scores[index] = calculateFourOfAKind(diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Small Straight":
                        this.scores[index] = calculateSmallStraight(diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Big Straight":
                        this.scores[index] = calculateBigStraight(diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Chance":
                        this.scores[index] = calculateChance(diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                    case "Yatzy":
                        this.scores[index] = calculateYatzy(diceValues);
                        this.catagoryUpdated[index] = true;
                        break;
                }
            }
            else if (index != 1) //if catagory does exist but already has been updated
            {
                Console.WriteLine("Catagory has already been updated");
            }
        }

        public void upDateTotalScore()
        {
            foreach (int score in this.scores)
            {
                this.totalScore += score;
            }
        }

        private int calculateOnesToSixes(int catagoryValue, int[] diceValues) //check outofbouds erorors
        {
            int sum = 0;

            foreach (int value in diceValues)
            {
                if (value == catagoryValue)
                {
                    sum += value;
                }
            }
            return sum;
        }

        private int calculatePair(int[] diceValues)
        {
            Array.Sort(diceValues); //sort by value
            Array.Reverse(diceValues); //get the highest value first

            for (int i = 0; i < diceValues.Length; i++)
            {
                if (diceValues[i] == diceValues[i + 1])
                {
                    return diceValues[i] * 2;
                }
            }
            return 0;
        }

        private int calculateTwoPairs(int[] diceValues)
        {
            int sum = 0;
            int pairCount = 0;
            Array.Sort(diceValues);
            Array.Reverse(diceValues);

            for (int i = 0; i < diceValues.Length; i++)
            {
                if (diceValues[i] == diceValues[i + 1])
                {
                    sum += diceValues[i] * 2;
                    pairCount++;

                    if (pairCount == 2)
                    {
                        break;
                    }
                    i++;
                }
            }
            if (pairCount == 2)
            {
                return sum;
            }
            else
            {
                return 0;
            }
        }//check outofbouds errors

        private int calculateTreeOfAKind(int[] diceValues)
        {
            Array.Sort(diceValues);

            for (int i = 0; i < diceValues.Length; i++)
            {
                if (diceValues[i] == diceValues[i + 1] && diceValues[i] == diceValues[i + 2])
                {
                    return diceValues[i] * 3;
                }
            }
            return 0;
        } //check outofbouds erros

        private int calculateFourOfAKind(int[] diceValues)
        {
            Array.Sort(diceValues);

            for (int i = 0; i < diceValues.Length; i++)
            {
                if (diceValues[i] == diceValues[i + 1] && diceValues[i] == diceValues[i + 2] && diceValues[i] == diceValues[i + 3])
                {
                    return diceValues[i] * 4;
                }
            }
            return 0;
        }

        private int calculateYatzy(int[] diceValues)
        {

            if (diceValues[0] == diceValues[1] && diceValues[0] == diceValues[2] && diceValues[0] == diceValues[3] && diceValues[0] == diceValues[4])
            {
                return diceValues[0] * 5;
            }

            return 0;
        }

        private int calculateSmallStraight(int[] diceValues)
        {
            Array.Sort(diceValues);

            for (int i = 0; i < 5; i++)
            {
                if (diceValues[i] == i + 1) //checking if dice1 = 1, dice 2 = 2 and so on..
                {
                    return 15;
                }
            }
            return 0;
        }

        private int calculateBigStraight(int[] diceValues)
        {
            for (int i = 0; i < 5; i++)
            {
                if (diceValues[i] == i + 2) //checking if dice1 = 2, dice 2 = 3 and so on..
                {
                    return 20;
                }
            }
            return 0;
        }

        private int calculateChance(int[] diceValues)
        {
            int sum = 0;
            foreach (int value in diceValues)
            {
                sum += value;
            }
            return sum;
        }

        public void printScoreboard()
        {
            Console.Clear();
            Console.WriteLine("SCOREBOARD");
            Console.WriteLine("----------------");
            for (int i = 0; i < this.catagoryNames.Length; i++)
            {
                Console.WriteLine(this.catagoryNames[i] + "-------------------" + this.scores[i]);
            }
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Total score ---------------" + this.totalScore);
            Console.WriteLine();
        }

    }
}
