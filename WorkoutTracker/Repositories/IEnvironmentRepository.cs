using System.Collections.Generic;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public interface IEnvironmentRepository
    {
        /// <summary>
        /// Creates a new Environment in the repository.
        /// </summary>
        /// <param name="WeatherID">WeatherID of the Environment to create.</param>
        /// <param name="LocationID">LocationID of the Environment to create.</param>
        /// <param name="IsIndoor">IsIndoor of the Environment to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Environment"/>.
        /// </returns>
        Environment CreateEnvironment(int WeatherID, int LocationID, int IsIndoor);
    }
}
