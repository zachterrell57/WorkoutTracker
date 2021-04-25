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

        public string Location { get; set; }

        public SqlDateTime Date { get; set; }

        public int Weight { get; set; }

        public int SleepDuration { get; set; }

        public int Calories { get; set; }

        public SqlDateTime StartTime { get; set; }

        public SqlDateTime EndTime { get; set; }

        public int Rating { get; set; }

        public int Duration { get; set; }

        public int AvgHeartRate { get; set; }

        public bool IsIndoor { get; set; }

        public WeatherType Type { get; set;}

        public int Name { get; set; }

        public void OnGet()
        {
        }
    }
}
