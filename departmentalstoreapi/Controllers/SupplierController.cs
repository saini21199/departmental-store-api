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
    public class SupplierController : ControllerBase
    {
        private readonly DepartmentContext _context;
        private readonly IMapper _mapper;

        public SupplierController(DepartmentContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        [HttpGet("")]
        public SupplierModel[] GetSuppliers()
        {
            IQueryable<Supplier> query = _context.supplier.Include(c => c.PurchaseOrders);
            var result = query.ToArray();

            //var result = from r in _context.supplier select r;
            return _mapper.Map<SupplierModel[]>(result);

        }
    }
}
