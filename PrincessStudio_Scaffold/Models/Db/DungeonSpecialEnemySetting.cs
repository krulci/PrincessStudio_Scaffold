using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class DungeonSpecialEnemySetting
    {
        public long Id { get; set; }
        public long SpecialBattleId { get; set; }
        public long EnemyIdentify { get; set; }
        public long DispOrder { get; set; }
        public long MustKillFlag { get; set; }
        public double DetailOffsetX { get; set; }
        public double DetailOffsetY { get; set; }
        public double DetailScale { get; set; }
    }
}
