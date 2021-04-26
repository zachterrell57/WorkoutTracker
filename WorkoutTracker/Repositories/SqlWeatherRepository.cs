using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Model;
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

        public Weather CreateWeather(WeatherType Type)
        {
            var d = new CreateWeatherDataDelegate(Type);
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
