using WorkoutTracker.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    internal class RetrieveSessionDataDelegate : NonQueryDataDelegate<Session>
    {
        private readonly int ;
        private readonly double Duration;
        private readonly double AvgHeartRate;

        public CreateSessionDataDelegate(int SessionID, double Duration, double AvgHeartRate)
           : base("Project.CreateWorkout")
        {
            this.SessionID = SessionID;
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

            p = command.Parameters.Add("SessionID", SqlDbType.Int);
            p.Value = SessionID;

            p = command.Parameters.Add("WorkoutID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;              
        }

        public override Workout Translate(SqlCommand command)
        {
            return new Workout((int)command.Parameters["WorkoutID"].Value, SessionID, Duration, AvgHeartRate);
        }
    }
}