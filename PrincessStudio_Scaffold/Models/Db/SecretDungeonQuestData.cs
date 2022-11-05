using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SecretDungeonQuestData
    {
        public long QuestId { get; set; }
        public long DungeonAreaId { get; set; }
        public long Difficulty { get; set; }
        public long FloorNum { get; set; }
        public long QuestType { get; set; }
        public long WaveGroupId { get; set; }
        public long LimitTime { get; set; }
        public long PartsHpSaveFlag { get; set; }
        public long EnergyResetFlag { get; set; }
        public long FixedStartTpRate { get; set; }
        public long Emax { get; set; }
        public long RewardImage1 { get; set; }
        public long RewardImage2 { get; set; }
        public long RewardImage3 { get; set; }
        public long RewardImage4 { get; set; }
        public long RewardImage5 { get; set; }
        public long RewardImage6 { get; set; }
        public long RewardCoin { get; set; }
        public long RewardCsc { get; set; }
        public long ChestId { get; set; }
        public long OddsGroupId { get; set; }
        public long Background { get; set; }
        public long DungeonQuestDetailBgId { get; set; }
        public long DungeonQuestDetailBgPosition { get; set; }
        public double DungeonQuestDetailMonsterSize { get; set; }
        public double QuestDetailMonsterScale1 { get; set; }
        public double QuestDetailMonsterScale2 { get; set; }
        public double QuestDetailMonsterScale3 { get; set; }
        public double QuestDetailMonsterScale4 { get; set; }
        public double QuestDetailMonsterScale5 { get; set; }
        public double DungeonQuestDetailMonsterPositionX1 { get; set; }
        public double DungeonQuestDetailMonsterPositionX2 { get; set; }
        public double DungeonQuestDetailMonsterPositionX3 { get; set; }
        public double DungeonQuestDetailMonsterPositionX4 { get; set; }
        public double DungeonQuestDetailMonsterPositionX5 { get; set; }
        public double DungeonQuestDetailMonsterHeight { get; set; }
        public double MultiTargetEffectTime { get; set; }
        public string WaveBgmSheetId1 { get; set; }
        public string WaveBgmQueId1 { get; set; }
    }
}
