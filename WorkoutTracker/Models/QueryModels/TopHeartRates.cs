using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class TopHeartRates
    {
        public double AvgHeartRate { get; }

        public string Date { get; }    

        public TopHeartRates(double AvgHeartRate, string Date)
        {
            this.Date = Date;
            this.AvgHeartRate = AvgHeartRate;
        }
    }
}
