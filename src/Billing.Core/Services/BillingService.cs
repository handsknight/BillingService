using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Core
{
    public class BillingService : IBillingService
    {

        private readonly IBillingRepository _billingRepository;

        public BillingService(IBillingRepository billingRepository)
        {
            _billingRepository = billingRepository;
        }

        public async Task<BillingDto> GetBill(BillingRequest param)
        {
            var res = await _billingRepository.GetLogAsync(param);
            if (res.Count() < 1)
                return new BillingDto
                {
                    CustomerName = param.CustomerName,
                    TotalApiHit = "No records found",
                    Bill = 0.ToString("C", CultureInfo.CurrentCulture),
                    Datefrom = param.DateFrom.ToString(),
                    DateTo = param.DateTo.ToString()
                };

            var totalCost = CountBand(res.Count());
             
            return new BillingDto
            {
                CustomerName = res[0].CustomerName,
                TotalApiHit = res.Count().ToString(),
                Bill = totalCost.ToString("C", CultureInfo.CurrentCulture),
                Datefrom = param.DateFrom.ToString(),
                DateTo = param.DateTo.ToString()
            };
        }

        public double CountBand(long noOfCalls)
        {
            long divisor = 1000;
            long remainder;
            double quotient;

            if (noOfCalls <= 1000000) // band 0 - 1,000,000
            {
                if (noOfCalls < 1000)
                    return 5;

                quotient = Math.DivRem(noOfCalls, divisor, out remainder);

                if (remainder > 0)
                    return (quotient * 5) + 5;
                else
                    return quotient * 5;
            }
            else if (noOfCalls > 1000000 && noOfCalls <= 10000000) // band 1,000,001 - 10,000,000
            {
                quotient = Math.DivRem(noOfCalls, divisor, out remainder);

                if (remainder > 0)
                    return (quotient * 4.2) + 4.2;
                else
                    return quotient * 4.2;
            }
            else //band 10,000,000 and above
            {
                quotient = Math.DivRem(noOfCalls, divisor, out remainder);

                if (remainder > 0)
                    return (quotient * 3.5) + 3.5;
                else
                    return quotient * 3.5;
            }
        }
    }
}
