using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace WorkoutTracker.Model
{
    public class DailyMetrics
    {
        public int MetricID { get; }

        public string Date { get; }

        public double Weight { get; }

        public double SleepDuration { get; }

        public double Calories { get; }

        internal DailyMetrics(int mID, string d, double w, double sd, double c)
        {
            MetricID = mID;
            Date = d;
            Weight = w;
            SleepDuration = sd;
            Calories = c;
        }
    }
}
