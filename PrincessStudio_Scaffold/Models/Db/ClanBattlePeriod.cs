﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ClanBattlePeriod
    {
        public long ClanBattleId { get; set; }
        public long Period { get; set; }
        public string PeriodDetail { get; set; }
        public long PeriodDetailBg { get; set; }
        public string PeriodDetailS { get; set; }
        public long PeriodDetailBgS { get; set; }
        public long PeriodDetailBgPosition { get; set; }
        public long PeriodDetailBossPositionX { get; set; }
        public long PeriodDetailBossPositionY { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string IntervalStart { get; set; }
        public string IntervalEnd { get; set; }
        public string CalcStart { get; set; }
        public string ResultStart { get; set; }
        public string ResultEnd { get; set; }
        public long LimitTime { get; set; }
        public long ChestId { get; set; }
        public long QuestDetailRehearsalLabelHeight { get; set; }
        public long MinCarryOverTime { get; set; }
    }
}
