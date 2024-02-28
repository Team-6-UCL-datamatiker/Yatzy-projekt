using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTest
{
    internal class Player
    {
        private string name;
        public Scoreboard PlayerScoreboard { get; set; }
        public Player()
        {
            this.name = "";
            PlayerScoreboard = new Scoreboard();
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

    }
}
