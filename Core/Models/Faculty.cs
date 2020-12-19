using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            Department = new HashSet<Department>();
        }

        public string FacCode { get; set; }
        public string FacFname { get; set; }
        public string FacLname { get; set; }
        public string FacGend { get; set; }
        public string FacPhone { get; set; }
        public string SchCode { get; set; }

        public virtual School SchCodeNavigation { get; set; }
        public virtual ICollection<Department> Department { get; set; }
    }
}
