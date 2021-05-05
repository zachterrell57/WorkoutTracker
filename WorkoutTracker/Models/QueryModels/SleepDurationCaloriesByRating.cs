using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class SleepDurationCaloriesByRating
    {
        public double SleepDuration { get; }

        public double Calories { get; }

        public string Date { get; }

        public SleepDurationCaloriesByRating(double SleepDuration, double Calories, string Date)
        {
            this.Date = Date;
            this.SleepDuration = SleepDuration;
            this.Calories = Calories;
        }
    }
}