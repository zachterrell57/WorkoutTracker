using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace WorkoutTracker.Model
{
    public class DailyMetrics
    {
        public int MetricID { get; }

        public SqlDateTime Date { get; }

        public int Weight { get; }

        public int SleepDuration { get; }

        public int Calories { get; }   

    }
}
