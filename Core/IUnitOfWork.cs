using StudentSystem.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Core
{
    public interface IUnitOfWork
    {
        //Write property of all repository which you gonna use.
        ISchoolRepository SchoolRepository { get; }
        Task<bool> SaveAsync();
    }
}
