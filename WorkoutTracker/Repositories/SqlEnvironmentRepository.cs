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
            //if (IsIndoor != 0 || IsIndoor != 1)
            //    throw new ArgumentException("The parameter cannot be null or empty.", nameof(IsIndoor));

            var d = new CreateEnvironmentDataDelegate(WeatherID, LocationID, IsIndoor);
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
