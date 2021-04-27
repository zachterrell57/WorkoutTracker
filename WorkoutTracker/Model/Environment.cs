using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Model
{
    public class Environment
    {
        public int EnvironmentID { get; }
        public int WeatherID { get; }
        public int LocationID { get;}
        public int IsIndoor { get;}

    



        internal Environment(int eID, int wID, int lID, int ii)
        {
            EnvironmentID = eID;
            WeatherID = wID;
            LocationID = lID;
            IsIndoor = ii;
        }
    }
}
