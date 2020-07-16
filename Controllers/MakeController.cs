using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AutomobileManagement.Controllers
{
    
    public class MakeController : Controller
    {
        [HttpGet("/api/makes")]
        public IActionResult GetMakes()
        {
            return Ok("Hi From Makes asd");
        }
    }
}