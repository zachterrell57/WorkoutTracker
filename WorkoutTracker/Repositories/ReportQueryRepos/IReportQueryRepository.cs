using System.Collections.Generic;
using WorkoutTracker.Model;

namespace WorkoutTracker
{
    public interface IReportQueryRepository
    {
        /// <summary>
        /// Retrieves all persons in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{TopHeartRates}"/> containing all persons.
        /// </returns>
        IReadOnlyList<TopHeartRates> RetrieveTopHeartRates();
    }
}
