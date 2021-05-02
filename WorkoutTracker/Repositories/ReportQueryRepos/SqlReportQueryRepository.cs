using System.Collections.Generic;
using DataAccess;
using WorkoutTracker.Model;
using WorkoutTracker.DataDelegates;
using System;

namespace WorkoutTracker
{
    public class SqlReportQueryRepository: IReportQueryRepository
    {

        private readonly SqlCommandExecutor executor;

        public SqlReportQueryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<TopHeartRates> RetrieveTopHeartRates()
        {
            return executor.ExecuteReader(new RetrieveTopHeartRatesDelegate());
        }
    }
}
