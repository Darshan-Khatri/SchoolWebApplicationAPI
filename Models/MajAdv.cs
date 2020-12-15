using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public partial class MajAdv
    {
        public string MajCode { get; set; }
        public string AdvCode { get; set; }
        public string MajAdvLevel { get; set; }

        public virtual Advisor AdvCodeNavigation { get; set; }
        public virtual Major MajCodeNavigation { get; set; }
    }
}
