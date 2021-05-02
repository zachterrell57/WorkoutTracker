using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class Workout
    {
        public int WorkoutID { get; }
        public int SessionID { get; }
     
        public double Duration { get; }
        public double AvgHeartRate { get; }

        internal Workout(int wID, int sID, double d, double ahr) 
        {
            WorkoutID = wID;
            SessionID = sID;      
            Duration = d;
            AvgHeartRate = ahr;
        }
    }
}
