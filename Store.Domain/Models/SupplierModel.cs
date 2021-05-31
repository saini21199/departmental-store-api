using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Models
{
    public class SupplierModel
    {
        public int supplier_id { get; set; }
        public string sup_name { get; set; }
        public string phone_no { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public ICollection<PurchaseModel> orders { get; set; }
    }
}
