using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutomobileManagement.DBContext;
using AutomobileManagement.Models;
using AutomobileManagement.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomobileManagement.Controllers
{
    
    public class MakeController : Controller
    {
        private readonly AutomobileDbContext context;
        private readonly IMapper  mapper ;
        public MakeController(AutomobileDbContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {

            var makes= await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}