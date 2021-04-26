using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Model;
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

        public Session CreateSession(string StartTime, string EndTime, double Rating)
        {
            if (string.IsNullOrWhiteSpace(StartTime))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(StartTime));

            if (string.IsNullOrWhiteSpace(EndTime))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(EndTime));

            if (Rating == 0)
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Rating));

            var d = new CreateSessionDataDelegate(StartTime, EndTime, Rating);
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
