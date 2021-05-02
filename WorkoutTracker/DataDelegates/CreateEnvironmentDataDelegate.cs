using WorkoutTracker.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    internal class CreateEnvironmentDataDelegate : NonQueryDataDelegate<Environment>
    {      
        private readonly int WeatherID;
        private readonly int LocationID;
        private readonly int IsIndoor;

        public CreateEnvironmentDataDelegate(int WeatherID, int LocationID, int IsIndoor)
           : base("Project.CreateEnvironment")
        {        
            this.WeatherID = WeatherID;
            this.LocationID = LocationID;
            this.IsIndoor = IsIndoor;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("IsIndoor", SqlDbType.Int);
            p.Value = IsIndoor;

            p = command.Parameters.Add("WeatherID", SqlDbType.Int);
            p.Value = WeatherID;

            p = command.Parameters.Add("LocationID", SqlDbType.Int);
            p.Value = LocationID;

            p = command.Parameters.Add("EnvironmentID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;          
        }

        public override Environment Translate(SqlCommand command)
        {
            return new Environment((int)command.Parameters["EnvironmentID"].Value,
                WeatherID, LocationID, IsIndoor);
        }
    }
}