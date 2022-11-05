using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class LegionBossEnemySetting
    {
        public long BossId { get; set; }
        public long DetailOffsetX { get; set; }
        public long DetailOffsetY { get; set; }
        public double DetailOffsetScale { get; set; }
    }
}
