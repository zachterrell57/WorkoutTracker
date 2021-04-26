using WorkoutTracker.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WorkoutTracker
{
    internal class RetrieveDailyMetricsDataDelegate : DataReaderDelegate<IReadOnlyList<DailyMetrics>>
    {
        private readonly int MetricID;

        public RetrieveDailyMetricsDataDelegate(int MetricID)
           : base("Project.RetrieveDailyMetrics")
        {
            this.MetricID = MetricID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MetricID", SqlDbType.Int);
            p.Value = MetricID;
        }
        public override IReadOnlyList<DailyMetrics> Translate(SqlCommand command, IDataRowReader reader)
        {
            var dailyMetrics = new List<DailyMetrics>();

            while (reader.Read())
            {
                dailyMetrics.Add(new DailyMetrics(
                   reader.GetInt32("MetricID"),
                   reader.GetString("Date"), 
                   reader.GetInt32("Weight"), //dont know how to get doubles
                   reader.GetInt32("SleepDuration"),
                   reader.GetInt32("Calories")));
            }

            return dailyMetrics;
        }
    }
}