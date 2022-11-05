using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class LegionBattleBonus
    {
        public long LegionBattleBonusId { get; set; }
        public long Type { get; set; }
        public long LegionBossId { get; set; }
        public string ConditionHp { get; set; }
        public long LegionBattleEffectId { get; set; }
        public long Duration { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
