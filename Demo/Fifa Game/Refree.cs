using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa_Game
{
    internal class Refree
    {
        public string? RefreeName { get; set; }
        public void Look(Ball ball)
        {
            Console.WriteLine($"Refree {RefreeName} is Looking Ball is {ball}");
        }

    }
}
