using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Models
{
    public class PurchaseModel
    {
        public int order_id { get; set; }
        public DateTime supply_date { get; set; }
        //public int supplier_id { get; set; }
    }
}
