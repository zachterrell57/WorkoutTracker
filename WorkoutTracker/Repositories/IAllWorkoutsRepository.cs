using System.Collections.Generic;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public interface IAllWorkoutsRepository
    {
        /// <summary>
        /// Retrieves all worrkouts in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{AllWorkouts}"/> containing all workouts.
        /// </returns>
        IReadOnlyList<AllWorkouts> RetrieveAllWorkouts();
    }
}
