using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public partial class StdAct
    {
        public string StdCode { get; set; }
        public string ActCode { get; set; }
        public int? StdActNum { get; set; }
        public DateTime? StdActJoined { get; set; }

        public virtual Activity ActCodeNavigation { get; set; }
        public virtual Student StdCodeNavigation { get; set; }
    }
}
