using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Models;
using System;

namespace WorkoutTracker
{
    public class SqlWorkoutRepository : IWorkoutRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlWorkoutRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Workout CreateWorkout(int SessionID, double Duration, double AvgHeartRate)
        {
            if (Duration == 0)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Duration));

            if (AvgHeartRate == 0)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(AvgHeartRate));

            var d = new CreateWorkoutDataDelegate(SessionID, Duration, AvgHeartRate);
            return executor.ExecuteNonQuery(d);
        }
    }
}
