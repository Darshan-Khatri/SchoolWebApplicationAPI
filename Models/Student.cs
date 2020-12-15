using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public partial class Student
    {
        public Student()
        {
            StdAct = new HashSet<StdAct>();
        }

        public string StdCode { get; set; }
        public string StdFname { get; set; }
        public string StdLname { get; set; }
        public string StdGend { get; set; }
        public string MajCode { get; set; }
        public DateTime? StdDob { get; set; }

        public virtual Major MajCodeNavigation { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ICollection<StdAct> StdAct { get; set; }
    }
}
