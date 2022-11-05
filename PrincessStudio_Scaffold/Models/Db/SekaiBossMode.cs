﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SekaiBossMode
    {
        public long SekaiBossModeId { get; set; }
        public long SekaiEnemyId { get; set; }
        public string SekaiEnemyLevel { get; set; }
        public long QuestDetailBgId { get; set; }
        public long QuestDetailBgPosition { get; set; }
        public double QuestDetailMonsterSize { get; set; }
        public long QuestDetailMonsterHeight { get; set; }
        public long LimitTime { get; set; }
        public long Background { get; set; }
        public string SheetId { get; set; }
        public string QueId { get; set; }
        public long ResultBossPositionY { get; set; }
        public long RewardGoldCoefficient { get; set; }
        public long LimitedMana { get; set; }
        public long ScoreCoefficient { get; set; }
    }
}
