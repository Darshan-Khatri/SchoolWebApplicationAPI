using Microsoft.EntityFrameworkCore;
using StudentSystem.Core.IRepositories;
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
            get { return Context as StudentDBContext; }
        }

        public Task<Student> SchoolFilter()
        {

            throw new NotImplementedException();
        }
    }
}
