using StudentSystem.Core;
using StudentSystem.Core.IRepositories;
using StudentSystem.Models;
using StudentSystem.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentDBContext _context;

        //public SchoolRepository SchoolRepository { get; private set; }

        public UnitOfWork(StudentDBContext context)
        {
            _context = context;
            // SchoolRepository = new SchoolRepository(_context);
        }

        //You must write signature of this property in IUnitOfWork Interface.
        public ISchoolRepository SchoolRepository => new SchoolRepository(_context);
        //public ISchoolRepository SchoolRepository { get; private set; }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
