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

        public int LocationID { get; }

        public bool IsIndoor { get; }
    }
}
