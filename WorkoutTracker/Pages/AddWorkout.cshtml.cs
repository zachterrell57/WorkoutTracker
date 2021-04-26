using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutTracker.Model;

namespace WorkoutTracker.Pages
{
    public class AddWorkoutModel : PageModel
    {
        //[BindProperty] //(SupportsGet = true) could need this
        public string Location { get; set; }
        
        public string Date { get; set; }
        
        public double Weight { get; set; }
       
        public double SleepDuration { get; set; }
        
        public double Calories { get; set; }
        
        public string StartTime { get; set; }

        public string EndTime { get; set; }
        
        public double Rating { get; set; }
        
        public double Duration { get; set; }
        
        public double AvgHeartRate { get; set; }
        
        public int IsIndoor { get; set; }
        
        public WeatherType WeatherType { get; set;}   

        public void OnGet()
        {
        }

        public void OnPost()
        {
            string location = Request.Form["Location"];
            if (location != null)
            {
                Location = location;
            }


            string date = Convert.ToString(Request.Form["Date"]);
            if (date != null)
            {
                Date = date;
            }

            double weight = Convert.ToDouble(Request.Form["Weight"]);
            if (weight != 0)
            {
                Weight = weight;
            }

            double sleepDuration = Convert.ToDouble(Request.Form["SleepDuration"]);
            if (sleepDuration != 0)
            {
                SleepDuration = sleepDuration;
            }

            double calories = Convert.ToDouble(Request.Form["Calories"]);
            if (calories != 0)
            {
                Calories = calories;
            }

            string startTime = Convert.ToString(Request.Form["StartTime"]);
            if (startTime != null)
            {
                StartTime = startTime;
            }

            string endTime = Convert.ToString(Request.Form["EndTime"]);
            if (endTime != null)
            {
                EndTime = endTime;
            }

            double rating = Convert.ToDouble(Request.Form["Rating"]);
            if (rating != 0)
            {
                Rating = rating;
            }

            double duration = Convert.ToDouble(Request.Form["Duration"]);
            if (duration != 0)
            {
                Duration = duration;
            }

            double avgHeartRate = Convert.ToDouble(Request.Form["AvgHeartRate"]);
            if (avgHeartRate != 0)
            {
                AvgHeartRate = avgHeartRate;
            }

            string isindoor = Request.Form["isIndoor"];
            if (isindoor != null)
            {
                if (isindoor == "Yes")
                {
                    IsIndoor = 1;
                }
                else
                {
                    IsIndoor = 0;
                }
            }

            string weather = Request.Form["Weather"];
            if (weather != null)
            {
                if (weather == "Sunny")
                {
                    WeatherType = WeatherType.Sunny;
                }
                else if (weather == "Rainy")
                {
                    WeatherType = WeatherType.Rainy;
                }
                else if (weather == "Clear")
                {
                    WeatherType = WeatherType.Clear;
                }
                else if (weather == "Overcast")
                {
                    WeatherType = WeatherType.Overcast;
                }
                else if (weather == "Snowing")
                {
                    WeatherType = WeatherType.Snowing;
                }
                else if (weather == "Hurricane")
                {
                    WeatherType = WeatherType.Hurricane;
                }
            }
        }
    }
}
