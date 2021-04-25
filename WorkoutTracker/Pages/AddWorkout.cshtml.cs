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

        //[BindProperty]
        public SqlDateTime Date { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Weight { get; set; }

        //[BindProperty]
        public int SleepDuration { get; set; }

        //[BindProperty]
        public int Calories { get; set; }

        //[BindProperty]
        public SqlDateTime StartTime { get; set; }

        //[BindProperty]
        public SqlDateTime EndTime { get; set; }

        //[BindProperty]
        public int Rating { get; set; }

        //[BindProperty]
        public int Duration { get; set; }

        //[BindProperty]
        public int AvgHeartRate { get; set; }

        //[BindProperty]
        public bool IsIndoor { get; set; }

        //[BindProperty]
        public WeatherType WeatherType { get; set;}

        //[BindProperty] 
        public int EnvironmentName { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Weight = Convert.ToInt32(Request.Form["Weight"]);
            Console.WriteLine(Weight);
        }
    }
}
