using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Models;
using System;

namespace WorkoutTracker
{
    public class SqlEnvironmentRepository : IEnvironmentRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlEnvironmentRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }


        public Models.Environment CreateEnvironment(int WeatherID, int LocationID, int IsIndoor)
        {
            var d = new CreateEnvironmentDataDelegate(WeatherID, LocationID, IsIndoor);
            return executor.ExecuteNonQuery(d);
        }
    }
}
