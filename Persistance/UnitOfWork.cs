using StudentSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task<bool> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
