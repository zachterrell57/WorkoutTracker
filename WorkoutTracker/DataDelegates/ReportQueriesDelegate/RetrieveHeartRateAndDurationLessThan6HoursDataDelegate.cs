using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutTracker.Models;
using DataAccess;
using System.Data.SqlClient;

namespace WorkoutTracker.DataDelegates
{
    internal class RetrieveHeartRateAndDurationLessThan6HoursDataDelegate : DataReaderDelegate<IReadOnlyList<HeartRateAndDurationLessThan6Hours>>
    {
        public RetrieveHeartRateAndDurationLessThan6HoursDataDelegate()
          : base("Project.HeartRateAndDurationLessThan6Hours")
        {
        }

        public override IReadOnlyList<HeartRateAndDurationLessThan6Hours> Translate(SqlCommand command, IDataRowReader reader)
        {
            var heartRateAndDurationLessThan6Hours = new List<HeartRateAndDurationLessThan6Hours>();

            while (reader.Read())
            {
                heartRateAndDurationLessThan6Hours.Add(new HeartRateAndDurationLessThan6Hours(
                    reader.GetDouble("AvgHeartRate"),
                    reader.GetDouble("Duration")
                 ));
            }

            return heartRateAndDurationLessThan6Hours;
        }
    }
}
