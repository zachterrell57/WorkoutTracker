using DataAccess;
using WorkoutTracker.Model;
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
               (double)reader.GetInt32("Rating"),
               reader.GetString("Date"),
               (double)reader.GetInt32("Weight"),
               (double)reader.GetInt32("SleepDuration"),
               (double)reader.GetInt32("Calories"),
              (double)reader.GetInt32("Duration"),
               (double)reader.GetInt32("AvgHeartRate"),
               reader.GetInt32("IsIndoor"),
              (WeatherType)reader.GetByte("Type"),
               reader.GetString("Name")));
            }

            return workouts;
        }
    }
}