using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    public class BillingDto
    {
        public string CustomerName { get; set; }
        public string TotalApiHit { get; set; }
        public string Bill { get; set; }
        public string Datefrom { get; set; }
        public string DateTo { get; set; }
    }
}
