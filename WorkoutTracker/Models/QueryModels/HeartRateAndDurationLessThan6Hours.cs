using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class HeartRateAndDurationLessThan6Hours
    {
        public double AvgHeartRate { get; set; }

        public double Duration { get; }       

        public HeartRateAndDurationLessThan6Hours(double AvgHeartRate, double Duration)
        {
            this.AvgHeartRate = AvgHeartRate;
            this.Duration = Duration;
        }
    }
}