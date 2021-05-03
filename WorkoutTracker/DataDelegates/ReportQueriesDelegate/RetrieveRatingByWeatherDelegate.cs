using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutTracker.Models;
using DataAccess;
using System.Data.SqlClient;

namespace WorkoutTracker.DataDelegates
{
    internal class RetrieveRatingByWeatherDelegate : DataReaderDelegate<IReadOnlyList<RatingByWeather>>
    {
        public RetrieveRatingByWeatherDelegate()
          : base("Project.RetrieveRatingBasedOnWeather")
        {
        }

        public override IReadOnlyList<RatingByWeather> Translate(SqlCommand command, IDataRowReader reader)
        {
            var ratingsByWeather = new List<RatingByWeather>();

            while (reader.Read())
            {
                ratingsByWeather.Add(new RatingByWeather(
                    reader.GetDouble("Rating"),                
                    reader.GetString("WeatherType"),
                    reader.GetString("Date")
                 ));
            }

            return ratingsByWeather;
        }
    }
}
