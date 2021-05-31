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
    public class AddressController : ControllerBase
    {
        private readonly DepartmentContext _context;
        private readonly IMapper _mapper;
        public AddressController(DepartmentContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("")]
        public AddressModel[] GetAddress(bool includeStaff = false)
        {

            IQueryable<Address> query = _context.address.Include(c => c.Staff);
            if (includeStaff)
            {
                query = query
                  .Include(c => c.Staff);
            }
            //query = query.OrderByDescending(c => c.EventDate);
            var result = query.ToArray();
            //IQueryable<Address> query = _context.address.Include(c => c.Staff);
            //var result1 = from r in _context.address select r;
            
            return _mapper.Map<AddressModel[]>(result);
            //return result.ToList();
        }
    }
}
