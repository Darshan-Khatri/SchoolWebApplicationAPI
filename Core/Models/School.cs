using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public partial class School
    {
        public School()
        {
            Advisor = new HashSet<Advisor>();
            Faculty = new HashSet<Faculty>();
            Major = new HashSet<Major>();
        }

        public string SchCode { get; set; }
        public string SchName { get; set; }
        public string SchPhone { get; set; }
        public string SchDeanName { get; set; }

        //This tables SchCode is used as FK in Advisor table
        public virtual ICollection<Advisor> Advisor { get; set; }

        //This tables SchCode is used as FK in Faculty table
        public virtual ICollection<Faculty> Faculty { get; set; }

        //This tables SchCode is used as FK in Major table
        public virtual ICollection<Major> Major { get; set; }
    }
}
