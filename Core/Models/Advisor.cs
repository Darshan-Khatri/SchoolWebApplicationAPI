using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public partial class Advisor
    {
        public Advisor()
        {
            MajAdv = new HashSet<MajAdv>();
        }

        public string AdvCode { get; set; }
        public string AdvFname { get; set; }
        public string AdvLname { get; set; }
        public string AdvPhone { get; set; }
        public string SchCode { get; set; }

        //This table has SchCode as FK
        public virtual School SchCodeNavigation { get; set; }

        //This tables AdvCode is used as FK in MajAdv table
        public virtual ICollection<MajAdv> MajAdv { get; set; }
    }
}
