using WorkoutTracker.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    internal class CreateEnvironmentDataDelegate : NonQueryDataDelegate<Environment>
    {      
        private readonly bool IsIndoor;

        public CreateEnvironmentDataDelegate(bool IsIndoor)
           : base("Project.CreateEnvironment")
        {
            this.IsIndoor = IsIndoor;        
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Date", SqlDbType.Int);
            p.Value = IsIndoor;

            p = command.Parameters.Add("EnvironmentID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("WeatherID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("LocationID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Environment Translate(SqlCommand command)
        {
            return new Environment((int)command.Parameters["EnvironmentID"].Value, 
                (int)command.Parameters["WeatherID"].Value, (int)command.Parameters["LocationID"].Value, IsIndoor);
        }
    }
}