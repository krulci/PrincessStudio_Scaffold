using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TowerEnemyParameter
    {
        public long EnemyId { get; set; }
        public long UnitId { get; set; }
        public string Name { get; set; }
        public long Level { get; set; }
        public long Rarity { get; set; }
        public long PromotionLevel { get; set; }
        public long Hp { get; set; }
        public long Atk { get; set; }
        public long MagicStr { get; set; }
        public long Def { get; set; }
        public long MagicDef { get; set; }
        public long PhysicalCritical { get; set; }
        public long MagicCritical { get; set; }
        public long WaveHpRecovery { get; set; }
        public long WaveEnergyRecovery { get; set; }
        public long Dodge { get; set; }
        public long PhysicalPenetrate { get; set; }
        public long MagicPenetrate { get; set; }
        public long LifeSteal { get; set; }
        public long HpRecoveryRate { get; set; }
        public long EnergyRecoveryRate { get; set; }
        public long EnergyReduceRate { get; set; }
        public long UnionBurstLevel { get; set; }
        public long MainSkillLv1 { get; set; }
        public long MainSkillLv2 { get; set; }
        public long MainSkillLv3 { get; set; }
        public long MainSkillLv4 { get; set; }
        public long MainSkillLv5 { get; set; }
        public long MainSkillLv6 { get; set; }
        public long MainSkillLv7 { get; set; }
        public long MainSkillLv8 { get; set; }
        public long MainSkillLv9 { get; set; }
        public long MainSkillLv10 { get; set; }
        public long ExSkillLv1 { get; set; }
        public long ExSkillLv2 { get; set; }
        public long ExSkillLv3 { get; set; }
        public long ExSkillLv4 { get; set; }
        public long ExSkillLv5 { get; set; }
        public long ResistStatusId { get; set; }
        public long ResistVariationId { get; set; }
        public long Accuracy { get; set; }
        public long EnemyColor { get; set; }
    }
}
