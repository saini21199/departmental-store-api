using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Models
{
    public class StaffModel
    {
        public int staff_id { set; get; }
        public string Staff_name { get; set; }
        public string phone_no { get; set; }
        //public int role_id { get; set; }
        //public int address_id { get; set; }
        public RoleModel role { get; set; }
        public AddressModel address { get; set; }
    }
}
