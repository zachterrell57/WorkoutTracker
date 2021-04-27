using WorkoutTracker.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WorkoutTracker
{
    internal class RetrieveWeatherDataDelegate : DataReaderDelegate<IReadOnlyList<Weather>>
    {
        private readonly int WeatherID;

        public RetrieveWeatherDataDelegate(int WeatherID)
           : base("Project.RetrieveWeather")
        {
            this.WeatherID = WeatherID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("WeatherID", SqlDbType.Int);
            p.Value = WeatherID;
        }
        public override IReadOnlyList<Weather> Translate(SqlCommand command, IDataRowReader reader)
        {
            var weather = new List<Weather>();

            while (reader.Read())
            {
                weather.Add(new Weather(
                   reader.GetInt32("WeatherID"),
                   reader.GetString("WeatherType")));  // Get byte? 
            }

            return weather;
        }
    }
}