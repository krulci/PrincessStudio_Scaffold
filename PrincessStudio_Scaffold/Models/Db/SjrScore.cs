using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SjrScore
    {
        public long Round { get; set; }
        public long Type { get; set; }
        public long FirstScore { get; set; }
        public long SecondScore { get; set; }
        public long ThirdScore { get; set; }
        public long TimeScore { get; set; }
        public long ActionScore { get; set; }
        public double NormalBonus { get; set; }
        public double HardBonus { get; set; }
        public double ExtraBonus { get; set; }
    }
}
