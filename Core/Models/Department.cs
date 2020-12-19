using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public partial class Department
    {
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string DeptPhone { get; set; }
        public string FacCode { get; set; }

        public virtual Faculty FacCodeNavigation { get; set; }
    }
}
