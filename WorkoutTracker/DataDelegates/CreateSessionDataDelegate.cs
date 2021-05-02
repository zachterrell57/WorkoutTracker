using WorkoutTracker.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    internal class CreateSessionDataDelegate : NonQueryDataDelegate<Session>
    {
        private readonly int MetricID;
        private readonly int EnvironmentID;
        private readonly string StartTime;
        private readonly string EndTime;
        private readonly double Rating;


        public CreateSessionDataDelegate(int MetricID, int EnvironmentID, string StartTime, string EndTime, double Rating)
           : base("Project.CreateSession")
        {
            this.MetricID = MetricID;
            this.EnvironmentID = EnvironmentID;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Rating = Rating;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("StartTime", SqlDbType.NVarChar);
            p.Value = StartTime;

            p = command.Parameters.Add("EndTime", SqlDbType.NVarChar);
            p.Value = EndTime;

            p = command.Parameters.Add("Rating", SqlDbType.Float);
            p.Value = Rating;

            p = command.Parameters.Add("MetricID", SqlDbType.Int);
            p.Value = MetricID;

            p = command.Parameters.Add("EnvironmentID", SqlDbType.Int);
            p.Value = EnvironmentID;

            p = command.Parameters.Add("SessionID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;    
        }

        public override Session Translate(SqlCommand command)
        {
            return new Session(
                (int)command.Parameters["SessionID"].Value, MetricID, EnvironmentID, StartTime, EndTime, Rating);
        }
    }
}