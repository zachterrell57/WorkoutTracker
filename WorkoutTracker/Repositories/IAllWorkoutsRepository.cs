using System.Collections.Generic;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public interface IAllWorkoutsRepository
    {
        /// <summary>
        /// Retrieves all persons in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Person}"/> containing all persons.
        /// </returns>
        IReadOnlyList<AllWorkouts> RetrieveAllWorkouts();

        /// <summary>
        /// Fetches the person with the given <paramref name="MetricId"/> if it exists.
        /// </summary>
        /// <param name="personId">Identifier of the person to fetch.</param>
        /// <returns>
        /// An instance of <see cref="Person"/> containing the information of the requested person.
        /// </returns>
        /// <exception cref="DataAccess.RecordNotFoundException">
        /// Thrown if <paramref name="personId"/> does not exist.
        /// </exception>
        //DailyMetrics FetchPerson(int personId);

        ///// <summary>
        ///// Gets the person with the given <paramref name="personId"/> if it exists.
        ///// </summary>
        ///// <param name="email">Email of the person to get.</param>
        ///// <returns>
        ///// An instance of <see cref="Person"/> containing the information of the requested person
        ///// if one exists with with the provided <paramref name="email"/>.
        ///// If one is not found, <c>null</c> is returned.
        ///// </returns>
        //AllWorkouts GetAllWorkouts(string StartTime, string Date, double Weight, double SleepDuration,
        //    double Calories, int IsIndoor, string EndTime, double Rating, string Name, WeatherType Type,
        //        double Duration, double AvgHeartRate);
    }
}
