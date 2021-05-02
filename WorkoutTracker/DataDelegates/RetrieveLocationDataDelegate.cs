using WorkoutTracker.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WorkoutTracker
{
    internal class RetrieveLocationDataDelegate : DataReaderDelegate<IReadOnlyList<Location>>
    {
        private readonly int LocationID;

        public RetrieveLocationDataDelegate(int LocationID)
           : base("Project.RetrieveLocation")
        {
            this.LocationID = LocationID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("LocationID", SqlDbType.Int);
            p.Value = LocationID;
        }
        public override IReadOnlyList<Location> Translate(SqlCommand command, IDataRowReader reader)
        {
            var location = new List<Location>();

            while (reader.Read())
            {
                location.Add(new Location(
                   reader.GetInt32("LocationID"),
                   reader.GetString("Name"))); 
            }

            return location;
        }
    }
}