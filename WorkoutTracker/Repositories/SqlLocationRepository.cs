using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Models;
using System;

namespace WorkoutTracker
{
    public class SqlLocationRepository : ILocationRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlLocationRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }


        public Location CreateLocation(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Name));
    

            var d = new CreateLocationDataDelegate(Name);
            return executor.ExecuteNonQuery(d);
        }
    }
}
