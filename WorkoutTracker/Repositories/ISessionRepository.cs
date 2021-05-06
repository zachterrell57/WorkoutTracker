using System.Collections.Generic;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public interface ISessionRepository
    {
        /// <summary>
        /// Creates a new person in the repository.
        /// </summary>
        /// <param name="MetricsID">MetricsID of the Session to create.</param>
        /// <param name="EnvironmentID">EnvironmentID of the Session to create.</param>
        /// <param name="StartTime">StartTime of the Session to create.</param>
        /// <param name="EndTime">EndTime of the Session to create.</param>
        /// <param name="Rating">Rating of the Session to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Session"/>.
        /// </returns>
        Session CreateSession(int MetricsID, int EnvironmentID, string StartTime, string EndTime, double Rating);
    }
}
