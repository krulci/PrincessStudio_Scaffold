using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class EReduction
    {
        public long Id { get; set; }
        public long Border { get; set; }
        public long Threshold1 { get; set; }
        public double Value1 { get; set; }
        public long Threshold2 { get; set; }
        public double Value2 { get; set; }
        public long Threshold3 { get; set; }
        public double Value3 { get; set; }
        public long Threshold4 { get; set; }
        public double Value4 { get; set; }
        public long Threshold5 { get; set; }
        public double Value5 { get; set; }
    }
}
