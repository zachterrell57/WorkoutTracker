using WorkoutTracker.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    internal class CreateWorkoutDataDelegate : NonQueryDataDelegate<Workout>
    {
        private readonly double Duration;
        private readonly double AvgHeartRate;

        public CreateWorkoutDataDelegate(double Duration, double AvgHeartRate)
           : base("Project.CreateWorkout")
        {
            this.Duration = Duration;
            this.AvgHeartRate = AvgHeartRate;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Duration", SqlDbType.Float);
            p.Value = Duration;

            p = command.Parameters.Add("AvgHeartRate", SqlDbType.Float);
            p.Value = AvgHeartRate;

            p = command.Parameters.Add("WorkoutID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("SessionID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            //p = command.Parameters.Add("GroupNameID", SqlDbType.Int);
           // p.Direction = ParameterDirection.Output;
        }

        public override Workout Translate(SqlCommand command)
        {
            return new Workout((int)command.Parameters["WorkoutID"].Value, (int)command.Parameters["SessionID"].Value, Duration, AvgHeartRate);
        }
    }
}