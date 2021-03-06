﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using StudentSystem.Core;
using StudentSystem.Core.Models;
using StudentSystem.Dtos;
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
        private readonly IMapper mapper;

        public SchoolController(IUnitOfWork uow, IMapper mapper)
        {
            this._unitOfWork = uow;
            this.mapper = mapper;
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

            //if (FilterValue != null)
            //{
            //    var query = await _unitOfWork.SchoolRepository.SchoolFilter(FilterValue);
            //    var Dto = mapper.Map<IEnumerable<SchoolDto>>(query);
            //    return Ok(Dto);
            //    //query = query.Where(s => s.SchCode == FilterValue.schCode);
            //}
            //else
            //{
            //    var query = await _unitOfWork.SchoolRepository.GetAll();
            //    var Dto = mapper.Map<IEnumerable<SchoolDto>>(query).ToList();
            //    return Ok(Dto);
            //}
            var query = await _unitOfWork.SchoolRepository.GetAll();
            var Dto = mapper.Map<IEnumerable<SchoolDto>>(query).ToList();
            return Ok(Dto);
        }

        [HttpGet("GetSchool/{Id}")]
        public async Task<IActionResult> GetSchool(string Id)
        {
            var query = await _unitOfWork.SchoolRepository.GetSingleRecord(Id);
            if (query != null)
            {
                var Dto = mapper.Map<School, SchoolDto>(query);
                return Ok(Dto);
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewSchool(SchoolDto body)
        {
            var dto = mapper.Map<SchoolDto, School>(body);
            _unitOfWork.SchoolRepository.AddRecord(dto);
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
        public async Task<IActionResult> UpdateSchool(string Id, SchoolDto school)
        {
            //Imp
            var querySchoolObj = _unitOfWork.SchoolRepository.GetSingleRecord(Id);

            querySchoolObj.Result.SchCode = school.SchCode;
            querySchoolObj.Result.SchName = school.SchName;
            querySchoolObj.Result.SchDeanName = school.SchDeanName;
            querySchoolObj.Result.SchPhone = school.SchPhone;


            await _unitOfWork.SaveAsync();
            return Ok(querySchoolObj.Result);
        }

        //[HttpGet("filter")]
        //public async Task<IActionResult> filteredList()
        //{
        //    var list = new List<string> { };
        //    var query = await _unitOfWork.SchoolRepository.SchoolFilter(list);
        //    return Ok(query);
        //}
    }
}
