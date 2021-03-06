using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace WorkoutTracker.Models
{
    public class Session
    {
        public int SessionID { get; set; }
        public int MetricID { get; set; }
        public int EnvironmentID { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public double Rating { get; set; }        

        internal Session(int sID, int mID, int eID, string st, string et, double r)
        {
            SessionID = sID;
            MetricID = mID;
            EnvironmentID = eID;
            StartTime = st;
            EndTime = et;
            Rating = r;
        }
    }
}
