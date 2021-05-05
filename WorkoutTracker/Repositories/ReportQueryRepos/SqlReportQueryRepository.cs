using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Models;
using WorkoutTracker.DataDelegates;
using System;

namespace WorkoutTracker
{
    public class SqlReportQueryRepository: IReportQueryRepository
    {

        private readonly SqlCommandExecutor executor;

        public SqlReportQueryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<TopHeartRates> RetrieveTopHeartRates()
        {
            return executor.ExecuteReader(new RetrieveTopHeartRatesDelegate());
        }

        public IReadOnlyList<RatingByWeather> RetrieveRatingsByWeather()
        {
            return executor.ExecuteReader(new RetrieveRatingByWeatherDelegate());
        }

        public IReadOnlyList<SleepDurationCaloriesByRating> RetrieveSleepDurationCaloriesByRating()
        {
            return executor.ExecuteReader(new RetrieveSleepDurationCaloriesByRatingDelegate());
        }

        public IReadOnlyList<HeartRateAndDurationLessThan6Hours> RetrieveHeartRateAndDurationLessThan6Hours()
        {
            return executor.ExecuteReader(new RetrieveHeartRateAndDurationLessThan6HoursDataDelegate());
        }
    }
}
