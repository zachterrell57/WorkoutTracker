using WorkoutTracker.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    internal class CreateLocationDataDelegate : NonQueryDataDelegate<Location>
    {
        private readonly string Name;

        public CreateLocationDataDelegate(string Name)
           : base("Project.CreateLocation")
        {
            this.Name = Name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = Name;  

            p = command.Parameters.Add("LocationID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Location Translate(SqlCommand command)
        {
            return new Location((int)command.Parameters["LocationID"].Value, Name);
        }
    }
}