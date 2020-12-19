using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Core.IRepositories
{
    public interface ICommonRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> GetSingleRecord(string Id);

        void AddRecord(TEntity NewRecord);

        bool DeleteRecord(string Id);

    }
}
