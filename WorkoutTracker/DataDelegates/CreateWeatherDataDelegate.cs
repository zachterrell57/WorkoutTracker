using WorkoutTracker.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    internal class CreateWeatherDataDelegate : NonQueryDataDelegate<Weather>
    {
        private readonly WeatherType Type;

        public CreateWeatherDataDelegate(WeatherType Type)
           : base("Project.CreateWeather")
        {
            this.Type = Type;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Type", SqlDbType.NVarChar);
            p.Value = Type;

            p = command.Parameters.Add("SessionID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Weather Translate(SqlCommand command)
        {
            return new Weather((int)command.Parameters["WeatherID"].Value, Type);
        }
    }
}