using WorkoutTracker.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WorkoutTracker
{
    internal class RetrieveSessionDataDelegate : DataReaderDelegate<IReadOnlyList<Session>>
    {
        private readonly int SessionID;

        public RetrieveSessionDataDelegate(int SessionID)
           : base("Project.RetrieveSession")
        {
            this.SessionID = SessionID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("SessionID", SqlDbType.Int);
            p.Value = SessionID;
        }
        public override IReadOnlyList<Session> Translate(SqlCommand command, IDataRowReader reader)
        {
            var session = new List<Session>();

            while (reader.Read())
            {
                session.Add(new Session(
                   reader.GetInt32("SessionID"),
                   reader.GetInt32("MetricID"), //dont know how to get fk
                   reader.GetInt32("EnvironmentID"),
                   reader.GetString("StartTime"),
                   reader.GetString("EndTime"),
                   reader.GetInt32("Rating")));  // doubles? 
            }

            return session;
        }
    }
}