using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Core.IRepositories
{
    public interface ISchoolRepository 
    {
        Task<Student> SchoolFilter();
    }
}
