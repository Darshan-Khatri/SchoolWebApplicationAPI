using StudentSystem.Core.IRepositories;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Persistance.Repositories
{
    // public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    public class CommonRepository<TEntity> : ICommonRepository<TEntity> where TEntity : class
    {
        private readonly StudentDBContext context;

        public CommonRepository(StudentDBContext context)
        {
            this.context = context;
        }
        public void AddRecord(TEntity NewRecord)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetSingleRecord(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
