using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SjrProperFeature
    {
        public long ProperId { get; set; }
        public long FeatureGroup1 { get; set; }
        public long FeatureGroup2 { get; set; }
        public long FeatureGroup3 { get; set; }
        public long Value1 { get; set; }
        public long Value2 { get; set; }
        public long Value3 { get; set; }
    }
}
