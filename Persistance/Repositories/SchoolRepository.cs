using StudentSystem.Core.IRepositories;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Persistance.Repositories
{
    public class SchoolRepository : ISchoolRepository, ICommonRepository<School>
    {
        public void AddRecord(School NewRecord)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<School>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<School> GetSingleRecord(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> SchoolFilter()
        {
            throw new NotImplementedException();
        }
    }
}
