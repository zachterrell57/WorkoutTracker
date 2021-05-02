using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Models;
using WorkoutTracker.DataDelegates;
using System;

namespace WorkoutTracker
{
    public class SqlAllWorkoutsRepository : IAllWorkoutsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlAllWorkoutsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public AllWorkouts GetAllWorkouts(string StartTime, string Date, double Weight, double SleepDuration,
            double Calories,int IsIndoor, string EndTime, double Rating, string Name, WeatherType Type,
                double Duration, double AvgHeartRate)
        {
            var d = new GetAllWorkoutsDataDelegate( IsIndoor,  Date,  Weight,  SleepDuration,
             Calories,  StartTime,  EndTime,  Rating,  Name,  Type,
                 Duration,  AvgHeartRate);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<AllWorkouts> RetrieveAllWorkouts()
        {
            return executor.ExecuteReader(new RetrieveAllWorkoutsDelegate());
        }
    }
}
