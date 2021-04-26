using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Model;
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


        public Model.Environment CreateEnvironment(int IsIndoor)
        {
            //if (IsIndoor != 0 || IsIndoor != 1)
            //    throw new ArgumentException("The parameter cannot be null or empty.", nameof(IsIndoor));

            var d = new CreateEnvironmentDataDelegate(IsIndoor);
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
