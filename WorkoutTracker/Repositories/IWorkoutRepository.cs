using System.Collections.Generic;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public interface IWorkoutRepository
    {
        /// <summary>
        /// Creates a new person in the repository.
        /// </summary>
        /// <param name="SessionID">SessionID of the Workout to create.</param>
        /// <param name="Duration">Duration of the Workout to create.</param>
        /// <param name="AvgHeartRate">AvgHeartRate of the Workout to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Workout"/>.
        /// </returns>
        Workout CreateWorkout(int SessionID, double Duration, double AvgHeartRate);
    }
}
