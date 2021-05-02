using WorkoutTracker.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    internal class CreateDailyMetricsDataDelegate : NonQueryDataDelegate<DailyMetrics>
    {
        private readonly string Date;
        private readonly double Weight;
        private readonly double SleepDuration;
        private readonly double Calories;

        public CreateDailyMetricsDataDelegate(string Date, double Weight, double SleepDuration, double Calories)
           : base("Project.CreateDailyMetrics")
        {
            this.Date = Date;
            this.Weight = Weight;
            this.SleepDuration = SleepDuration;
            this.Calories = Calories;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Date", SqlDbType.NVarChar);
            p.Value = Date;

            p = command.Parameters.Add("Weight", SqlDbType.Float);
            p.Value = Weight;

            p = command.Parameters.Add("SleepDuration", SqlDbType.Float);
            p.Value = SleepDuration;

            p = command.Parameters.Add("Calories", SqlDbType.Float);
            p.Value = Calories;

            p = command.Parameters.Add("MetricID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override DailyMetrics Translate(SqlCommand command)
        {
            return new DailyMetrics((int)command.Parameters["MetricID"].Value, Date, Weight, SleepDuration, Calories);
        }
    }
}