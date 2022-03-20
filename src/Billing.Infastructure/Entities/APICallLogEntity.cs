using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Infastructure
{
    public class APICallLogEntity
    {
        public long Id { get; set; }
        public string APIServiceId { get; set; }
        public string CustomerName { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CallDate { get; set; }
        public bool CallThrough { get; set; }
    }
}
