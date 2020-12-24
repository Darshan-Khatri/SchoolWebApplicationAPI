using Microsoft.EntityFrameworkCore;
using StudentSystem.Core.IRepositories;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Persistance.Repositories
{
    public class AdvisorRepository : CommonRepository<Advisor>, IAdvisorRepository
    {
        public AdvisorRepository(StudentDBContext context) : base(context)
        {

        }

        public StudentDBContext StudentDBContext
        {
            //"Context"(CommonRepository) here is different from our "context" defined in this class.
            get { return Context as StudentDBContext; }
        }

        public async Task<IEnumerable<string>> getAdvisors()
        {
            var query = await entity.Select(s => s.SchCodeNavigation.SchName).ToListAsync();
            return query;
            //throw new NotImplementedException();
        }
    }
}
