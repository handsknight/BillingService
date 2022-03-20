using Billing.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Billing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
        private readonly IBillingService _billingService;
        private readonly ILogger<BillingController> _logger;

        public BillingController(IBillingService billingService, ILogger<BillingController> logger)
        {
            _billingService = billingService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<BillingDto> GetBill(BillingRequest param)
        {
            _logger.LogInformation($"{nameof(BillingController)} calling billingService to get bill");
            
            try
            {
                var res = await _billingService.GetBill(param);
                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError($" Error {ex} occured in {nameof(BillingController)} while calling billingService to get bill");

                throw;
            }


        }

    }
}
