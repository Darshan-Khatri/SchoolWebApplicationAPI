using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using StudentSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly IUnitOfWork uow;

        public SchoolController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var v = "Working Student controller!.";
            return Ok(v);
        }

        [HttpGet("AllSchool")]
        public async Task<IActionResult> GetAllSchool()
        {
           
            throw new NotImplementedException();
        }
    }
}
