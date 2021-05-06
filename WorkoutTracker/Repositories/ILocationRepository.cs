using System.Collections.Generic;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public interface ILocationRepository
    {
        /// <summary>
        /// Creates a new person in the repository.
        /// </summary>
        /// <param name="Name">Name of the Location to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Location"/>.
        /// </returns>
        Location CreateLocation(string Name);
    }
}
