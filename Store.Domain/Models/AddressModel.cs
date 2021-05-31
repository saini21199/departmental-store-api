using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Models
{
    public class AddressModel
    {
        public int address_id { get; set; }
        public string addressLine_1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public long pincode { get; set; }
        //public ICollection<StaffModel> Staff { get; set; }
    }
}
