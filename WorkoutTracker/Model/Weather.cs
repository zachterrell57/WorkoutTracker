using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Model
{
    public class Weather
    {
        public int WeatherID { get; }
        public WeatherType Type { get; }

        internal Weather(int wID, WeatherType t)
        {
            WeatherID = wID;
            Type = t;
        }
    }
}
