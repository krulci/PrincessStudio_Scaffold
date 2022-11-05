using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class LegionBattleBonusEffect
    {
        public long LegionBattleEffectId { get; set; }
        public long EnemyId { get; set; }
        public long IconId { get; set; }
        public long TextId { get; set; }
        public long SkillId { get; set; }
        public long TargetType { get; set; }
    }
}
