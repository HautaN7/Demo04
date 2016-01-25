using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApp
{
    class Radio
    {
        // max/min frequency & volume
        private readonly double maxFrequency = 26000.0;
        private readonly double minFrequency = 2000.0;
        private double frequency;

        private readonly int maxVolume = 9;
        private readonly int minVolume = 0;
        private int volume;

        public bool On = true;
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value <= maxFrequency) frequency =  value;
                else
                {
                    Console.WriteLine("Too high frequency - set to max!");
                    frequency = maxFrequency;
                }
                if (value >= minFrequency) frequency = value;
                else
                {
                    Console.WriteLine("Frequency too low - set to min!");
                    frequency = minFrequency;
                }
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume) volume = value;
                else
                {
                    Console.WriteLine("Too high volume - set to max!");
                    volume = maxVolume;
                }
                if (value >= minVolume) volume = value;
                else
                {
                    Console.WriteLine("Volume too low - set to min!");
                    volume = minVolume;
                }
        }
    }
}
