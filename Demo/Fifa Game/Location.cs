using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa_Game
{
    public struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString()
        {
            return $"X={X}, Y={Y}, Z={Z}";
        }
        public static bool operator==(Location a, Location b)
        {
            if ((a.X == b.X) && (a.Y == b.Y) && (a.Z == b.Z))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Location a, Location b)
        {
            if ((a.X != b.X) || (a.Y != b.Y) || (a.Z != b.Z))
            {
                return true;
            }
            return false;
        }
    }
}
