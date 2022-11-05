using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SeriesUnlockCondition
    {
        public long SequelEventId { get; set; }
        public long ConditionStoryId1 { get; set; }
        public long ConditionStoryId2 { get; set; }
        public long ConditionEventId { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionBossId { get; set; }
    }
}
