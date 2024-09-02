using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa_Game
{
    internal class Player
    {
        public string PlayerName { get; set; }
        public string TeamName { get; set; }

        public void Run(Ball ball)
        {
            Console.WriteLine($"player {PlayerName} is Running......... Ball is {ball}");
        }
    }
}
