using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutTracker.Model;

namespace WorkoutTracker.Pages
{
    public class ArchiveModel : PageModel
    {

        const string connectionString = @"Server=ZACHTERRELL5AA7\SQLEXPRESS;Database=ProjectDatabase;Integrated Security=SSPI;";

        private IAllWorkoutsRepository allWorkoutsRepo;
        private TransactionScope transaction;

        //public List<string> Location { get; set; }

        //public List<string> Date { get; set; }

        //public List<double> Weight { get; set; }

        //public List<double> SleepDuration { get; set; }

        //public List<double> Calories { get; set; }

        //public List<string> StartTime { get; set; }

        //public List<string> EndTime { get; set; }

        //public List<double> Rating { get; set; }

        //public List<double> Duration { get; set; }

        //public List<double> AvgHeartRate { get; set; }

        //public List<int> IsIndoor { get; set; }

        public List<WeatherType> WeatherType { get; set; }

        public IReadOnlyList<AllWorkouts> workouts;

        public void OnGet()
        {
            transaction = new TransactionScope();
            allWorkoutsRepo = new SqlAllWorkoutsRepository(connectionString);
            transaction.Dispose();

            workouts = allWorkoutsRepo.RetrieveAllWorkouts();
        }

        public void OnPost()
        {

        }
    }
}
