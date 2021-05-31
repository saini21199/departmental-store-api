using AutoMapper;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Profiles
{
    public class StaffProfile: Profile
    {
        public StaffProfile() {
            this.CreateMap<Staff, StaffModel>().ForMember(x=>x.role,o=>o.MapFrom(z=>z.roles)).ForMember(x => x.address, o => o.MapFrom(z => z.addresses));
            this.CreateMap<Role, RoleModel>();
            this.CreateMap<Address, AddressModel>();
        }
    }
}
