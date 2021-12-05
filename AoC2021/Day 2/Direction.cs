using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Day_2
{
    public class Direction
    {
        string direction;
        int distance;

        public Direction(string direction, int distance)
        {
            this.direction = direction;
            this.distance = distance;
        }

        public string getDirection()
        {
            return direction;
        }

        public int getDistance()
        {
            return distance;
        }
    }
}
