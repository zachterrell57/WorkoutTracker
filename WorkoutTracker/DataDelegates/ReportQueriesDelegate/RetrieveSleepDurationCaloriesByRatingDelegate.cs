using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutTracker.Models;
using DataAccess;
using System.Data.SqlClient;

namespace WorkoutTracker.DataDelegates
{
    internal class RetrieveSleepDurationCaloriesByRatingDelegate : DataReaderDelegate<IReadOnlyList<SleepDurationCaloriesByRating>>
    {
        public RetrieveSleepDurationCaloriesByRatingDelegate()
          : base("Project.SleepDurationCaloriesByRating")
        {
        }

        public override IReadOnlyList<SleepDurationCaloriesByRating> Translate(SqlCommand command, IDataRowReader reader)
        {
            var sleepDurationCaloriesByRating = new List<SleepDurationCaloriesByRating>();

            while (reader.Read())
            {
                sleepDurationCaloriesByRating.Add(new SleepDurationCaloriesByRating(
                    reader.GetDouble("SleepDuration"),
                    reader.GetDouble("Calories"),
                    reader.GetString("Date")
                 ));
            }

            return sleepDurationCaloriesByRating;
        }
    }
}
