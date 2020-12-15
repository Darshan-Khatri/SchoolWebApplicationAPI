using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public partial class Activity
    {
        public Activity()
        {
            StdAct = new HashSet<StdAct>();
        }

        public string ActCode { get; set; }
        public string ActName { get; set; }
        public decimal? ActFee { get; set; }

        public virtual ICollection<StdAct> StdAct { get; set; }
    }
}
