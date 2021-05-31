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
    public class StaffController : ControllerBase
    {
        private readonly DepartmentContext _context;

        private readonly IMapper _mapper;
        public StaffController(DepartmentContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet("")]
        public StaffModel[] GetStaffs()
        {
            IQueryable<Staff> query = _context.staff.Include(c => c.roles).Include(x=>x.addresses);
            var result = query.ToArray();
            return _mapper.Map<StaffModel[]>(result);
        }

        [HttpGet("{id}")]
        public StaffModel GetStaffById(int id)
        {
            IQueryable<Staff> query = _context.staff.Include(c => c.roles).Include(x=>x.addresses).Where(i => i.staff_id == id);

            Staff result = query.FirstOrDefault();
            return _mapper.Map<StaffModel>(result);
        }

        [HttpPost("")]
        public StaffModel PostStaff(Staff staff)
        {
            _context.staff.Add(staff);
            _context.SaveChanges();
            return GetStaffById(staff.staff_id);
        }

        [HttpPut("{id}")]
        public void UpdateStaff(Staff staff, int id)
        {
            _context.Entry(staff).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
