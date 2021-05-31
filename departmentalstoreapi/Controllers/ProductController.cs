using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store.Data;
using Store.Domain;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace departmentalstoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DepartmentContext _context;

        private readonly IMapper _mapper;
        public ProductController(DepartmentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("")]
        public ProductModel[] GetProducts(bool includecategory = false)
        {
            if (includecategory == true)
            {
                IQueryable<Product> query = _context.product.Include(c => c.category);
                var result = query.ToArray();
                return _mapper.Map<ProductModel[]>(result);
            }
            else
            {
                IQueryable<Product> query1 = _context.product;
                var result1 = query1.ToArray();
                return _mapper.Map<ProductModel[]>(result1);
            }
        }

        [HttpGet("{id}")]
        public ProductModel GetProductById(int id)
        {
            IQueryable<Product> query = _context.product.Include(c => c.category).Where(i => i.product_id == id);
            Product result = query.FirstOrDefault();
            return _mapper.Map<ProductModel>(result);
        }

        [HttpPost("")]
        public ProductModel PostProducts(Product product)
        {
            _context.product.Add(product);
            _context.SaveChanges();
            return GetProductById(product.product_id);
        }

        [HttpPut("{id}")]
        public void UpdateProduct(Product product, int id)
        {
            _context.Entry(product).State = EntityState.Modified;
            //Product query = _context.product.Include(c => c.category).Where(i => i.product_id == id).FirstOrDefault();
            //_mapper.Map(product, query);
            _context.SaveChanges();

            //Product query = _context.product.Include(c => c.categories).Where(i => i.product_id == id);
            //query = product;
            //ProductModel prod = GetProductById(id);
            //_mapper.Map()
            //_mapper.Map(product, result);
            //IQueryable<Product> query = _context.product.Include(c => c.categories).Where(i => i.product_id == id);
            //var result = query;
            //return _mapper.Map<ProductModel[]>(result);
        }
    }
}

