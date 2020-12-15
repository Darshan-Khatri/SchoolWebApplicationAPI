using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public partial class Major
    {
        public Major()
        {
            MajAdv = new HashSet<MajAdv>();
            Student = new HashSet<Student>();
        }

        public string MajCode { get; set; }
        public string MajDesc { get; set; }
        public string SchCode { get; set; }

        public virtual School SchCodeNavigation { get; set; }
        public virtual ICollection<MajAdv> MajAdv { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
