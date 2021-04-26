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
        //public int GroupNameID { get; }
        public double Duration { get; }
        public double AvgHeartRate { get; }

        internal Workout(int wID, int sID, double d, double ahr) //int gnID,
        {
            WorkoutID = wID;
            SessionID = sID;
            //GroupNameID = gnID;
            Duration = d;
            AvgHeartRate = ahr;
        }
    }
}
