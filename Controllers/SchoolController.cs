﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using StudentSystem.Core;
using StudentSystem.Models;
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
        private readonly IUnitOfWork _unitOfWork;

        public SchoolController(IUnitOfWork uow)
        {
            this._unitOfWork = uow;
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
            var query = await _unitOfWork.SchoolRepository.GetAll();
            return Ok(query);
        }

        [HttpGet("GetSchool/{Id}")]
        public async Task<IActionResult> GetSchool(string Id)
        {
            var query = await _unitOfWork.SchoolRepository.GetSingleRecord(Id);
            if (query != null)
                return Ok(query);
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewSchool(School body)
        {
            _unitOfWork.SchoolRepository.AddRecord(body);
            await _unitOfWork.SaveAsync();
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> RemoveSchool(string Id)
        {
            var queryResult = _unitOfWork.SchoolRepository.DeleteRecord(Id);
            if (queryResult)
            {
                await _unitOfWork.SaveAsync();
                return Ok(Id);
            }
            return BadRequest();
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateSchool(string Id, School school)
        {
            var querySchoolObj = _unitOfWork.SchoolRepository.GetSingleRecord(Id);
            
            querySchoolObj.Result.SchCode = school.SchCode;
            querySchoolObj.Result.SchName = school.SchName;
            querySchoolObj.Result.SchDeanName = school.SchDeanName;
            querySchoolObj.Result.SchPhone = school.SchPhone;


            await _unitOfWork.SaveAsync();
            return Ok(querySchoolObj.Status);
        }
    }
}
