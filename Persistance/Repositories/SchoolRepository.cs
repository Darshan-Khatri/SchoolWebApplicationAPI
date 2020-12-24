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
    //Inherit CommonRepository CLASS not ICommonRepository INTERFACE
    public class SchoolRepository : CommonRepository<School>, ISchoolRepository
    {

        public SchoolRepository(StudentDBContext context) : base(context)
        {
            
        }

        //Use this property to use CommonRepositoy methods.
        //You must make CommonRepositoy fileds PROTECTED because you are inheriting from from parent calls(CommonRepositoy)
        public StudentDBContext StudentDBContext
        {
            //"Context"(CommonRepository) here is different from our "context" defined in this class.
            get { return Context as StudentDBContext; }
        }

        
        public async Task<IEnumerable<School>> SchoolFilter(Filter filterList)
        {
            //You are able to write entity.Where, because We are inherating from CommonRepositoy class.
            var query = await entity.Where(s => s.SchCode == filterList.schCode).ToListAsync();
            return query;
        }
    } 
}
