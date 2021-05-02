using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class AllWorkouts
    {
        public int IsIndoor { get; }

        public string Date { get; }

        public double Weight { get; }

        public double SleepDuration { get; }

        public double Calories { get; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public double Rating { get; set; }

        public string Name { get; }

        public string Type { get; }

        public double Duration { get; }

        public double AvgHeartRate { get; }

        public AllWorkouts(string StartTime, string EndTime, double Rating, string Date, double Weight, double SleepDuration, 
            double Calories, double Duration, double AvgHeartRate, int IsIndoor, string Type, string Name)
        {
            this.IsIndoor = IsIndoor;
            this.Date = Date;
            this.Weight = Weight;
            this.SleepDuration = SleepDuration;
            this.Calories = Calories;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Rating = Rating;
            this.Name = Name;
            this.Duration = Duration;
            this.AvgHeartRate = AvgHeartRate;
            this.Type = Type;
        }
    }
}
