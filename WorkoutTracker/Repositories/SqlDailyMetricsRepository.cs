using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Models;
using System;

namespace WorkoutTracker
{
    public class SqlDailyMetricsRepository : IDailyMetricsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlDailyMetricsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public DailyMetrics CreateDailyMetrics(string Date, double Weight, double SleepDuration, double Calories)
        {
            if (string.IsNullOrWhiteSpace(Date))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Date));

            if (Weight == 0)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Weight));

            if (SleepDuration == 0)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(SleepDuration));

            if (Calories == 0)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Calories));

            var d = new CreateDailyMetricsDataDelegate(Date, Weight, SleepDuration, Calories);
            return executor.ExecuteNonQuery(d);
        }

        //public Person FetchPerson(int personId)
        //{
        //    var d = new FetchPersonDataDelegate(personId);
        //    return executor.ExecuteReader(d);
        //}

        //public Person GetPerson(string email)
        //{
        //    var d = new GetPersonDataDelegate(email);
        //    return executor.ExecuteReader(d);
        //}

        //public IReadOnlyList<Person> RetrievePersons()
        //{
        //    return executor.ExecuteReader(new RetrievePersonsDataDelegate());
        //}
    }
}
