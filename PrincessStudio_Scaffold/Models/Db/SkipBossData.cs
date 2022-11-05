using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SkipBossData
    {
        public long BossId { get; set; }
        public long SkipMotionId { get; set; }
        public long SkipBgId { get; set; }
        public long SkipPositionX { get; set; }
        public long SkipPositionY { get; set; }
        public double SkipScaleX { get; set; }
        public double SkipScaleY { get; set; }
    }
}
