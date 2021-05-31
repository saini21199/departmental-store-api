using AutoMapper;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain
{
    public class PurchaseProfile : Profile
    {
        public PurchaseProfile() {
            this.CreateMap<PurchaseOrder, PurchaseModel>();
            this.CreateMap<Supplier, SupplierModel>().ForMember(c=>c.orders,o=>o.MapFrom(z=>z.PurchaseOrders));
        }
    }
}
