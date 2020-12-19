using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Core.IRepositories
{
    //Add ICommonRepository Interface that will gives you access to all common method that you would need.
    public interface ISchoolRepository : ICommonRepository<School>
    {
        Task<Student> SchoolFilter();
    }
}
