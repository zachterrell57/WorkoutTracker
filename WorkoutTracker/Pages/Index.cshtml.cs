using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Threading.Tasks;
using WorkoutTracker.Model;

namespace WorkoutTracker.Pages
{
    public class IndexModel : PageModel
    {    
        const string connectionString = @"Server=ZACHTERRELL5AA7\SQLEXPRESS;Database=ProjectDatabase;Integrated Security=SSPI;";

        private IReportQueryRepository reportQueriesRepo;
        private TransactionScope transaction;
        public IReadOnlyList<TopHeartRates> topHeartRates;

        private readonly ILogger<IndexModel> _logger;       

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            transaction = new TransactionScope();
            reportQueriesRepo = new SqlReportQueryRepository(connectionString);
            transaction.Dispose();

            topHeartRates = reportQueriesRepo.RetrieveTopHeartRates();
        }
    }
}
