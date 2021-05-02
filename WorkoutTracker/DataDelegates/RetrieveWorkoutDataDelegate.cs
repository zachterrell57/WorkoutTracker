using WorkoutTracker.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WorkoutTracker
{
    internal class RetrieveWorkoutDataDelegate : DataReaderDelegate<IReadOnlyList<Workout>>
    {
        private readonly int WorkoutID;

        public RetrieveWorkoutDataDelegate(int WorkoutID)
           : base("Project.RetrieveWorkout")
        {
            this.WorkoutID = WorkoutID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("WorkoutID", SqlDbType.Int);
            p.Value = WorkoutID;
        }
        public override IReadOnlyList<Workout> Translate(SqlCommand command, IDataRowReader reader)
        {
            var workout = new List<Workout>();

            while (reader.Read())
            {
                workout.Add(new Workout(
                   reader.GetInt32("WorkoutID"),
                   reader.GetInt32("SessionID"), //dont know how to get fk
                   (double)reader.GetInt32("Duration"), 
                   (double)reader.GetInt32("AvgHeartRate")));  
            }

            return workout;
        }
    }
}