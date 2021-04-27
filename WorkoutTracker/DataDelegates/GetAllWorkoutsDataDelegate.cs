using DataAccess;
using WorkoutTracker.Model;
using System.Data.SqlClient;

namespace WorkoutTracker.DataDelegates
{
    internal class GetAllWorkoutsDataDelegate : DataReaderDelegate<AllWorkouts>
    {
        private int IsIndoor;

        private string Date;

        private double Weight;

        private double SleepDuration;

        private double Calories;

        private string StartTime;

        private string EndTime;

        private double Rating;

        private string Name;

        private WeatherType Type;

        private double Duration;

        private double AvgHeartRate;

        public GetAllWorkoutsDataDelegate(int IsIndoor, string Date, double Weight, double SleepDuration,
            double Calories, string StartTime, string EndTime, double Rating, string Name, WeatherType Type,
                double Duration, double AvgHeartRate)
           : base("Person.GetAllWorkouts")
        {
            this.IsIndoor = IsIndoor;
            this.Date = Date;
            this.Weight = Weight;
            this.SleepDuration = SleepDuration;
            this.Calories = Calories;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Rating = Rating;
            this.Name = Name;
            this.Duration = Duration;
            this.Type = Type;
            this.AvgHeartRate = AvgHeartRate;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);


            command.Parameters.AddWithValue("StartTime", StartTime);
            command.Parameters.AddWithValue("EndTime", EndTime);
            command.Parameters.AddWithValue("Rating", Rating);
            command.Parameters.AddWithValue("Date", Date);
            command.Parameters.AddWithValue("Weight", Weight);
            command.Parameters.AddWithValue("SleepDuration", SleepDuration);
            command.Parameters.AddWithValue("Calories", Calories);
            command.Parameters.AddWithValue("Duration", Duration);
            command.Parameters.AddWithValue("AvgHeartRate", AvgHeartRate);
            command.Parameters.AddWithValue("IsIndoor", IsIndoor);
            command.Parameters.AddWithValue("Type", Type);
            command.Parameters.AddWithValue("Name", Name);
        }

        public override AllWorkouts Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new AllWorkouts (
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
               reader.GetString("Name"));
        }
    }
}