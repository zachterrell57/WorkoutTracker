using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutTracker.Models
{
    public class RatingByWeather
    {
        public double Rating { get; set; }

        public string WeatherType { get; }

        public string Date { get; }

        public RatingByWeather(double Rating, string WeatherType, string Date)
        {
            this.Date = Date;
            this.WeatherType = WeatherType;
            this.Rating = Rating;
        }
    }
}
