using Microsoft.EntityFrameworkCore;
using StudentSystem.Core.IRepositories;
using StudentSystem.Core.Models;
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
        protected readonly DbSet<TEntity> entity;

        public CommonRepository(DbContext context)
        {
            this.Context = context;
            entity = this.Context.Set<TEntity>();
        }
        public async void AddRecord(TEntity NewRecord)
        {
            var query = await entity.AddAsync(NewRecord);
        }

        public bool DeleteRecord(string Id)
        {
            //Don't include unnecessay async and await. If you include FindAsync overhere then it can create issue.
            //Since before finding id it will return false if you include async.
            var query = entity.Find(Id);
            if (query != null)
            {
                entity.Remove(query);
                return true;
            }
            else { return false; }

        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var query = await entity.ToListAsync();
            return query;
        }

        public async Task<TEntity> GetSingleRecord(string Id)
        {
            var query = await entity.FindAsync(Id);
            return query;
        }
    }
}
