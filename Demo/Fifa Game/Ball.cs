using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa_Game
{
    internal class Ball
    {
        public int Id { get; set; }
        private Location location;
        public Location Location
        {
            get { return location; }
            set
            {
                if (value != location)
                {
                    location = value;
                    //notify subscribers
                    BallLocationChanged?.Invoke(this);
                }

            }
        }
        public event Action<Ball>? BallLocationChanged;
        public override string ToString()
        {
            return $"Id={Id} , Location={Location}";
        }
    }
}
