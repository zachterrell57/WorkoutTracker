using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Model;
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
