using WorkoutTracker.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WorkoutTracker
{
    internal class RetrieveEnvironmentDataDelegate : DataReaderDelegate<IReadOnlyList<Environment>>
    {
        private readonly int EnvironmentID;

        public RetrieveEnvironmentDataDelegate(int EnvironmentID)
           : base("Project.RetrieveEnvironment")
        {
            this.EnvironmentID = EnvironmentID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("EnvironmentID", SqlDbType.Int);
            p.Value = EnvironmentID;
        }
        public override IReadOnlyList<Environment> Translate(SqlCommand command, IDataRowReader reader)
        {
            var environment = new List<Environment>();

            while (reader.Read())
            {
                environment.Add(new Environment(
                   reader.GetInt32("EnvironmentID"),
                   reader.GetInt32("WeatherID"), //dont know how to get fk
                   reader.GetInt32("LocationID"), 
                   reader.GetInt32("IsIndoor"))); 
            }

            return environment;
        }
    }
}