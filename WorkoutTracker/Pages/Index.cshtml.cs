using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutTracker.Models;
using Highsoft.Web.Mvc.Charts;


namespace WorkoutTracker.Pages
{
    public class IndexModel : PageModel
    {    
        const string connectionString = @"Server=ZACHTERRELL5AA7\SQLEXPRESS;Database=ProjectDatabase;Integrated Security=SSPI;";

        private IReportQueryRepository reportQueriesRepo;
        private TransactionScope transaction;
        public IReadOnlyList<TopHeartRates> topHeartRates;
        public IReadOnlyList<RatingByWeather> ratingsByWeather;
        public IReadOnlyList<SleepDurationCaloriesByRating> sleepDurationCaloriesByRating;
        public IReadOnlyList<HeartRateAndDurationLessThan6Hours> heartRateAndDurationLessThan6Hours;

        public void OnGet()
        {
            transaction = new TransactionScope();
            reportQueriesRepo = new SqlReportQueryRepository(connectionString);        
            transaction.Dispose();

            topHeartRates = reportQueriesRepo.RetrieveTopHeartRates();
            ratingsByWeather = reportQueriesRepo.RetrieveRatingsByWeather();
            sleepDurationCaloriesByRating = reportQueriesRepo.RetrieveSleepDurationCaloriesByRating();
            heartRateAndDurationLessThan6Hours = reportQueriesRepo.RetrieveHeartRateAndDurationLessThan6Hours();
        }
    }
}
