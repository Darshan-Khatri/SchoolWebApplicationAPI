using StudentSystem.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Core
{
    public interface IUnitOfWork
    {
        //Write property of all repositories which you gonna use.
        ISchoolRepository SchoolRepository { get; }
        IAdvisorRepository AdvisorRepository { get; }
        Task<bool> SaveAsync();
    }
}
