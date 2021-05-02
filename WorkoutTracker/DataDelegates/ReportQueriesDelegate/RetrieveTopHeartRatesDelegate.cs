using DataAccess;
using WorkoutTracker.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WorkoutTracker.DataDelegates
{
    internal class RetrieveTopHeartRatesDelegate: DataReaderDelegate<IReadOnlyList<TopHeartRates>>
    {
        public RetrieveTopHeartRatesDelegate() 
          : base("Project.RetrieveTopHeartRates")
        {
        }

        public override IReadOnlyList<TopHeartRates> Translate(SqlCommand command, IDataRowReader reader)
        {
            var topHeartRates = new List<TopHeartRates>();

            while (reader.Read())
            {
               topHeartRates.Add(new TopHeartRates(
               reader.GetDouble("AvgHeartRate"),
               reader.GetString("Date")
                ));
            }

            return topHeartRates;
        }
    }
}
