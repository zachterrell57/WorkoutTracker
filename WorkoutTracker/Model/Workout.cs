using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Model
{
    public class Workout
    {
        public int WorkoutID { get; }
        public int SessionID { get; }
        public int GroupNameID { get; }
        public int Duration { get; }
        public int AvgHeartRate { get; }

        internal Workout(int wID, int sID, int gnID, int d, int ahr)
        {
            WorkoutID = wID;
            SessionID = sID;
            GroupNameID = gnID;
            Duration = d;
            AvgHeartRate = ahr;
        }
    }
}
