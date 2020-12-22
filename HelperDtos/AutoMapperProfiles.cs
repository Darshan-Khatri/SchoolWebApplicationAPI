using AutoMapper;
using StudentSystem.Dtos;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.HelperDtos
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<School, SchoolDto>().ReverseMap();
        }
    }
}
