using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Models;
using System;

namespace WorkoutTracker
{
    public class SqlWeatherRepository : IWeatherRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlWeatherRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Weather CreateWeather(string Type)
        {
            var d = new CreateWeatherDataDelegate(Type);
            return executor.ExecuteNonQuery(d);
        }
    }
}
