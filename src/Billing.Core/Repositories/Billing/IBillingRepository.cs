using Billing.Infastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Billing.Core
{
    public interface IBillingRepository
    {
        Task<List<APICallLogEntity>> GetLogAsync(BillingRequest param);
    }
}


