using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Lift lift = new Lift();
            lift.Floor = 0;
            Console.WriteLine("Lift is at floor: " + lift.Floor);
            Console.ReadLine();


        }
    }
}
