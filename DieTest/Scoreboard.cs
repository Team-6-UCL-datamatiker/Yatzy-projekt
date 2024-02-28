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
        private string[] catagoryNames = { "ONES", "TWOS", "THREES", "FOURS", "FIVES", "SIXES", "PAIR", "TWO PAIRS", "THREE OF A KIND", "FOUR OF A KIND", "SMALL STRAIGHT", "BIG STRAIGHT", "CHANCE", "YATZY" };
        private int totalScore = 0;

        public Scoreboard()
        {
            this.scores = new int[catagoryNames.Length];
            this.catagoryUpdated = new bool[catagoryNames.Length];


        }

        public void SetScore(string catagory, int[] diceValues)
        {
            int index = Array.IndexOf(this.catagoryNames, catagory); //the index of the selected catagory in the catagory array. retuns -1 if not found

            if (index != -1)
            {
                if (this.catagoryUpdated[index] == false)
                {
                    switch (catagory)
                    {
                        case "ONES":
                            this.scores[index] = CalculateOnesToSixes(1, diceValues);
                            break;
                        case "TWOS":
                            this.scores[index] = CalculateOnesToSixes(2, diceValues);
                            break;
                        case "THREES":
                            this.scores[index] = CalculateOnesToSixes(3, diceValues);
                            break;
                        case "FOURS":
                            this.scores[index] = CalculateOnesToSixes(4, diceValues);
                            break;
                        case "FIVES":
                            this.scores[index] = CalculateOnesToSixes(5, diceValues);
                            break;
                        case "Sixes":
                            this.scores[index] = CalculateOnesToSixes(6, diceValues);
                            break;
                        case "PAIR":
                            this.scores[index] = CalculatePair(diceValues);
                            break;
                        case "TWO PAIRS":
                            this.scores[index] = CalculateTwoPairs(diceValues);
                            break;
                        case "THREE OF A KIND":
                            this.scores[index] = CalculateTreeOfAKind(diceValues);
                            break;
                        case "FOUR OF A KIND":
                            this.scores[index] = CalculateFourOfAKind(diceValues);
                            this.catagoryUpdated[index] = true;
                            break;
                        case "SMALL STRAIGHT":
                            this.scores[index] = CalculateSmallStraight(diceValues);
                            break;
                        case "BIG STRAIGHT":
                            this.scores[index] = CalculateBigStraight(diceValues);
                            break;
                        case "CHANCE":
                            this.scores[index] = CalculateChance(diceValues);
                            break;
                        case "YATZY":
                            this.scores[index] = CalculateYatzy(diceValues);
                            break;
                    }
                    this.catagoryUpdated[index] = true;
                    UpdateTotalScore();

                }
                else //if catagory does exist but already has been updated
                {
                    Console.WriteLine("Catagory already updated!");
                    SetScore(Console.ReadLine(), diceValues);
                }
            }
            else
            {
                Console.WriteLine("Catagory not found!");
                SetScore(Console.ReadLine(), diceValues);
            }
        }

        public void UpDateTotalScore()
        {
            foreach (int score in this.scores)
            {
                this.totalScore += score;
            }
        }

        private int CalculateOnesToSixes(int catagoryValue, int[] diceValues) //check outofbouds erorors
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

        private int CalculatePair(int[] diceValues)
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

        private int CalculateTwoPairs(int[] diceValues)
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

        private int CalculateTreeOfAKind(int[] diceValues)
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

        private int CalculateFourOfAKind(int[] diceValues)
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

        private int CalculateYatzy(int[] diceValues)
        {

            if (diceValues[0] == diceValues[1] && diceValues[0] == diceValues[2] && diceValues[0] == diceValues[3] && diceValues[0] == diceValues[4])
            {
                return diceValues[0] * 5;
            }

            return 0;
        }

        private int CalculateSmallStraight(int[] diceValues)
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

        private int CalculateBigStraight(int[] diceValues)
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

        private int CalculateChance(int[] diceValues)
        {
            int sum = 0;
            foreach (int value in diceValues)
            {
                sum += value;
            }
            return sum;
        }

        private void UpdateTotalScore()
        {
            this.totalScore = 0;
            foreach (int score in scores)
            {
                this.totalScore += score;
            }
        }

        public int GetTotalScore()
        {
            return this.totalScore;
        }

        public void PrintScoreboard()
        {
            Console.Clear();
            Console.WriteLine("SCOREBOARD");
            Console.WriteLine("----------------");
            for (int i = 0; i < this.catagoryNames.Length; i++)
            {
                Console.WriteLine(this.catagoryNames[i] + "-------------------" + this.scores[i]);
            }
            Console.WriteLine("________________________________\n");
            Console.WriteLine("Total score ---------------" + this.totalScore);
            Console.WriteLine();
        }

    }
}
