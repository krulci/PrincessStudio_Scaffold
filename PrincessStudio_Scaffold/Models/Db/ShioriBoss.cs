using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ShioriBoss
    {
        public long BossId { get; set; }
        public long EventId { get; set; }
        public long AreaId { get; set; }
        public long Difficulty { get; set; }
        public string QuestName { get; set; }
        public long PositionX { get; set; }
        public long PositionY { get; set; }
        public long BossPositionX { get; set; }
        public long BossPositionY { get; set; }
        public long ResultBossPositionY { get; set; }
        public long IconId { get; set; }
        public double IconDisplayScale { get; set; }
        public double IconColliderScale { get; set; }
        public long LimitTime { get; set; }
        public long ClearRewardGroup { get; set; }
        public long Background1 { get; set; }
        public long WaveGroupId1 { get; set; }
        public string WaveBgmSheetId1 { get; set; }
        public string WaveBgmQueId1 { get; set; }
        public long StoryIdWavestart1 { get; set; }
        public long StoryIdWaveend1 { get; set; }
        public long DetailBgId { get; set; }
        public long DetailBgPosition { get; set; }
        public double DetailBossBgSize { get; set; }
        public double DetailBossBgHeight { get; set; }
        public double MapPositionX { get; set; }
        public double MapPositionY { get; set; }
        public double MapSize { get; set; }
        public double MapArrowOffset { get; set; }
        public double DeatailAuraSize { get; set; }
        public double MapAuraSize { get; set; }
        public long DispOnBg { get; set; }
        public long QdMode { get; set; }
    }
}
