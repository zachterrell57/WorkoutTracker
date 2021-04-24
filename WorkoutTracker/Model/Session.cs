using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Model
{
    public class Session
    {
        public int SessionID { get; set; }

        public int MetricID { get; set; }

        public int EnvironmentID { get; set; }

        //public int StartTime { get; set; }

        //public int EndTime { get; set; }

        public int Rating { get; set; }

        //public int Date { get; set; }

    }
}
