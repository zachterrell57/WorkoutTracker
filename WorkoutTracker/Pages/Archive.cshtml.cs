using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutTracker.Models;

namespace WorkoutTracker.Pages
{
    public class ArchiveModel : PageModel
    {

        const string connectionString = @"Server=ZACHTERRELL5AA7\SQLEXPRESS;Database=ProjectDatabase;Integrated Security=SSPI;";

        private IAllWorkoutsRepository allWorkoutsRepo;
        private TransactionScope transaction;
        
        public IReadOnlyList<AllWorkouts> Workouts{ get; set; }

        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; } = "Date";

        public void OnGet()
        {
            transaction = new TransactionScope();
            allWorkoutsRepo = new SqlAllWorkoutsRepository(connectionString);
            transaction.Dispose();

            
            Workouts = allWorkoutsRepo.RetrieveAllWorkouts(Filter);
        }

        public void OnPost()
        {
            transaction = new TransactionScope();
            allWorkoutsRepo = new SqlAllWorkoutsRepository(connectionString);
            transaction.Dispose();
            Filter = Request.Form["Filter"];

            Workouts = allWorkoutsRepo.RetrieveAllWorkouts(Filter);
        }
    }
}
