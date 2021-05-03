using System.Collections.Generic;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public interface IReportQueryRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{TopHeartRates}"/> 
        /// </returns>
        IReadOnlyList<TopHeartRates> RetrieveTopHeartRates();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{RatingByWeather}"/> 
        /// </returns>
        IReadOnlyList<RatingByWeather> RetrieveRatingsByWeather();
    }
}
