using Billing.Infastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Billing.Core
{
    public class BillingRepository: IBillingRepository
    {
        private ApplicationDbContext _dbContext;
        private readonly ILogger<BillingRepository> _logger;

        public BillingRepository(ApplicationDbContext dbContext, ILogger<BillingRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<List<APICallLogEntity>> GetLogAsync(BillingRequest param)
        {
            _logger.LogInformation($"{nameof(BillingRepository)} Fetching APICallLogs from dbcontext");
            return await _dbContext.APICallLogs.Where(b => b.CustomerName == param.CustomerName && (b.CallDate >= param.DateFrom && b.CallDate <= param.DateTo)).ToListAsync();
        }
    }
}
