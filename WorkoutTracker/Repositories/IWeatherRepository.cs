using System.Collections.Generic;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public interface IWeatherRepository
    {

        /// <summary>
        /// Creates a new weather in the repository.
        /// </summary>
        /// <param name="Type">The type of weather to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Weather"/>.
        /// </returns>
        Weather CreateWeather(string Type);
    }
}
