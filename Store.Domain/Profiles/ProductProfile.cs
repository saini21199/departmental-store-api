using AutoMapper;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile() {
            this.CreateMap<Product, ProductModel>().ReverseMap();
            this.CreateMap<Category, CategoryModel>().ReverseMap();
        }
    }
}
