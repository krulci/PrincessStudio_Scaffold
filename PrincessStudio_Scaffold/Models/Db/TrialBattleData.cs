using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TrialBattleData
    {
        public long QuestId { get; set; }
        public long CategoryId { get; set; }
        public long Difficulty { get; set; }
        public string BattleName { get; set; }
        public long DetailBgId { get; set; }
        public long DetailBgPosition { get; set; }
        public long DetailBossBgSize { get; set; }
        public long DetailBossBgHeight { get; set; }
        public long ResultBossPositionY { get; set; }
        public long LimitTime { get; set; }
        public long Background { get; set; }
        public long WaveGroupId { get; set; }
        public string WaveBgmSheetId { get; set; }
        public string WaveBgmQueId { get; set; }
        public long ClearRewardGroup { get; set; }
    }
}
