using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class Weather
    {
        public int WeatherID { get; }
        public string Type { get; }

        internal Weather(int wID, string t)
        {
            WeatherID = wID;
            Type = t;
        }
    }
}
