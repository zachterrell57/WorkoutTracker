using DataAccess;
using WorkoutTracker.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WorkoutTracker.DataDelegates
{
    internal class RetrieveAllWorkoutsDelegate : DataReaderDelegate<IReadOnlyList<AllWorkouts>>
    {
        public RetrieveAllWorkoutsDelegate()
           : base("Project.RetrieveWorkouts")
        {
        }

        public override IReadOnlyList<AllWorkouts> Translate(SqlCommand command, IDataRowReader reader)
        {
            var workouts = new List<AllWorkouts>();

            while (reader.Read())
            {
                workouts.Add(new AllWorkouts(
               reader.GetString("StartTime"),
               reader.GetString("EndTime"),
               reader.GetDouble("Rating"),
               reader.GetString("Date"),
               reader.GetDouble("Weight"),
               reader.GetDouble("SleepDuration"),
               reader.GetDouble("Calories"),
              reader.GetDouble("Duration"),
               reader.GetDouble("AvgHeartRate"),
               reader.GetInt32("IsIndoor"),
               reader.GetString("WeatherType"),
               reader.GetString("Name")));
            }

            return workouts;
        }
    }
}