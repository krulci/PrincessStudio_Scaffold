using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SjrChara
    {
        public long SjrCharaId { get; set; }
        public long UnitId { get; set; }
        public long Personality { get; set; }
        public long Speed { get; set; }
        public long TiredCoefficient { get; set; }
        public long Spring { get; set; }
        public double ResumeTime { get; set; }
        public long ProperId { get; set; }
        public long UbId { get; set; }
        public double TpLength { get; set; }
        public string Description { get; set; }
        public long RecommendType1 { get; set; }
        public long RecommendType2 { get; set; }
        public long RecommendType3 { get; set; }
    }
}
