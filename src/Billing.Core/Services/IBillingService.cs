using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Core
{
    public interface IBillingService
    {
        Task<BillingDto> GetBill(BillingRequest param);
    }
}
