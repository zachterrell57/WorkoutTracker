using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Models;
using System;

namespace WorkoutTracker
{
    public class SqlSessionRepository : ISessionRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlSessionRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Session CreateSession(int MetricID, int EnvironmentID, string StartTime, string EndTime, double Rating)
        {
            if (string.IsNullOrWhiteSpace(StartTime))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(StartTime));

            if (string.IsNullOrWhiteSpace(EndTime))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(EndTime));

            if (Rating == 0)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Rating));

            var d = new CreateSessionDataDelegate(MetricID, EnvironmentID, StartTime, EndTime, Rating);
            return executor.ExecuteNonQuery(d);
        }
    }
}
