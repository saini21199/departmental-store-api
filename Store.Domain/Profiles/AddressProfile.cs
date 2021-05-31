using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Store.Domain.Models;

namespace Store.Domain
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            this.CreateMap<Address, AddressModel>();
            this.CreateMap<Staff, StaffModel>();
        }
    }
}
