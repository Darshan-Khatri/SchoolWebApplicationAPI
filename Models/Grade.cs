using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public partial class Grade
    {
        public string StdCode { get; set; }
        public string StdFname { get; set; }
        public string StdLname { get; set; }
        public int? GrT1 { get; set; }
        public int? GrT2 { get; set; }
        public int? GrHw { get; set; }
        public int? GrPr { get; set; }
        public int? GrAvg { get; set; }
        public string GrLg { get; set; }

        public virtual Student StdCodeNavigation { get; set; }
    }
}
