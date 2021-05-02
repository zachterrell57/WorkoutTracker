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
