using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentSystem.Core;
using StudentSystem.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvisorController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public AdvisorController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("GetAllAdvisor")]
        public async Task<ActionResult> AllAdvisor()
        {
            var query = await unitOfWork.AdvisorRepository.GetAll();            
            return Ok(query);
        }

        [HttpGet("GetAdvisorSchName")]
        public async Task<ActionResult> AllAdvisorSchName()
        {
            var query = await unitOfWork.AdvisorRepository.getAdvisors();
            return Ok(query);
        }
    }
}
