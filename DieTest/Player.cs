using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Player
    {
        int[] scores = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        string[] combs = {"1'ere", "2'ere", "3'ere","4'ere","5'ere","6'ere","Et par","To par","Tre ens","Fire ens","Lille straight","Store straight","Chancen","Yatzy" };
        public string name;
        public int number;



        public Player(string playerName, int playerNumber)
        
        {

            name = playerName;
            number = playerNumber;



        } 



    }

}
