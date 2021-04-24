using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.DataAccess
{
    public class Workout
    {
        public int WorkoutID { get; }

        public int SessionID { get; }

        public int GroupNameID { get; }

        public int Duration { get; }

        public int AvgHeartRate { get; }
    }
}
