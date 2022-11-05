using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneSpecialBattle
    {
        public long EventId { get; set; }
        public long Mode { get; set; }
        public long RecommendedLevel { get; set; }
        public long PurposeType { get; set; }
        public long PurposeCount { get; set; }
        public long TriggerHp { get; set; }
        public long StoryIdModeStart { get; set; }
        public long StoryIdModeEnd { get; set; }
        public long WaveGroupId { get; set; }
        public long UnnecessaryDefeatChara { get; set; }
        public double StoryStartSecond { get; set; }
        public double ActionStartSecond { get; set; }
        public long HpGaugeColorFlag { get; set; }
        public long StartIdleTrigger { get; set; }
        public double AppearTime { get; set; }
        public double DetailBossBgSize { get; set; }
        public double DetailBossBgHeight { get; set; }
        public string DetailBossMotion { get; set; }
        public long IsHideBoss { get; set; }
    }
}
