using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Core
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();
    }
}
