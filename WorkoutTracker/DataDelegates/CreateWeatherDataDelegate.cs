using WorkoutTracker.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    internal class CreateWeatherDataDelegate : NonQueryDataDelegate<Weather>
    {
        private readonly WeatherType WeatherType;

        public CreateWeatherDataDelegate(WeatherType WeatherType)
           : base("Project.CreateWeather")
        {
            this.WeatherType = WeatherType;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("WeatherType", SqlDbType.NVarChar);
            p.Value = WeatherType; 

            p = command.Parameters.Add("WeatherID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Weather Translate(SqlCommand command)
        {
            return new Weather((int)command.Parameters["WeatherID"].Value, WeatherType);
        }
    }
}