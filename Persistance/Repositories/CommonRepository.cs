using Microsoft.EntityFrameworkCore;
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
        //Make this PROTECTD without fail. Since this fields would be inherited by child class
        protected readonly DbContext Context;
        //protected readonly DbSet<TEntity> entity;

        public CommonRepository(DbContext context)
        {
            this.Context = context;
            //entity = this.Context.Set<TEntity>();
        }
        public void AddRecord(TEntity NewRecord)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var query = await Context.Set<TEntity>().ToListAsync();
            return query;
        }

        public Task<TEntity> GetSingleRecord(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
