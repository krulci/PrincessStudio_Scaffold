using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneBossEnemySetting
    {
        public long BossId { get; set; }
        public long EnemyIdentify { get; set; }
        public long EventId { get; set; }
        public long MustKillFlag { get; set; }
        public long EventBossTreasureBoxId { get; set; }
        public double RewardGoldCoefficient { get; set; }
        public long RewardGoldLimit { get; set; }
        public long DetailOffsetX { get; set; }
        public long DetailOffsetY { get; set; }
        public double DetailScale { get; set; }
        public long MapOffsetX { get; set; }
        public long MapOffsetY { get; set; }
        public double MapScale { get; set; }
        public long MapDepth { get; set; }
    }
}
