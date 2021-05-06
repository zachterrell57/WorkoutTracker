using System.Collections.Generic;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public interface IDailyMetricsRepository
    {
        /// <summary>
        /// Creates a new DailyMetric in the repository.
        /// </summary>
        /// <param name="Date">Date of the DailyMetric to create.</param>
        /// <param name="Weight">Weight of the DailyMetric to create.</param>
        /// <param name="SleepDuration">SleepDuration of the DailyMetric to create.</param>
        /// /// <param name="Calories">Calories of the DailyMetric to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Person"/>.
        /// </returns>
        DailyMetrics CreateDailyMetrics(string Date, double Weight, double SleepDuration, double Calories);
    }
}
