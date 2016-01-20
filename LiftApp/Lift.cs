using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftApp
{
    class Lift
    {
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;

        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= maxFloor) floor = value;
                else
                {
                    Console.WriteLine("Floor too high - max floor is 5");
                }
                if (value >= minFloor) floor = value;
                else
                {
                    Console.WriteLine("Floor too low - min floor is 1");
                }
            }
        }
    }
}
