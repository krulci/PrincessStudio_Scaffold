using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ExEquipmentData
    {
        public long ExEquipmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Rarity { get; set; }
        public long Category { get; set; }
        public long RestrictionId { get; set; }
        public long ClanBattleEquipFlag { get; set; }
        public long DefaultHp { get; set; }
        public long MaxHp { get; set; }
        public long DefaultAtk { get; set; }
        public long MaxAtk { get; set; }
        public long DefaultMagicStr { get; set; }
        public long MaxMagicStr { get; set; }
        public long DefaultDef { get; set; }
        public long MaxDef { get; set; }
        public long DefaultMagicDef { get; set; }
        public long MaxMagicDef { get; set; }
        public long DefaultPhysicalCritical { get; set; }
        public long MaxPhysicalCritical { get; set; }
        public long DefaultMagicCritical { get; set; }
        public long MaxMagicCritical { get; set; }
        public long DefaultWaveHpRecovery { get; set; }
        public long MaxWaveHpRecovery { get; set; }
        public long DefaultWaveEnergyRecovery { get; set; }
        public long MaxWaveEnergyRecovery { get; set; }
        public long DefaultDodge { get; set; }
        public long MaxDodge { get; set; }
        public long DefaultPhysicalPenetrate { get; set; }
        public long MaxPhysicalPenetrate { get; set; }
        public long DefaultMagicPenetrate { get; set; }
        public long MaxMagicPenetrate { get; set; }
        public long DefaultLifeSteal { get; set; }
        public long MaxLifeSteal { get; set; }
        public long DefaultHpRecoveryRate { get; set; }
        public long MaxHpRecoveryRate { get; set; }
        public long DefaultEnergyRecoveryRate { get; set; }
        public long MaxEnergyRecoveryRate { get; set; }
        public long DefaultEnergyReduceRate { get; set; }
        public long MaxEnergyReduceRate { get; set; }
        public long DefaultAccuracy { get; set; }
        public long MaxAccuracy { get; set; }
        public long PassiveSkillId1 { get; set; }
        public long PassiveSkillId2 { get; set; }
        public long PassiveSkillPower { get; set; }
    }
}
