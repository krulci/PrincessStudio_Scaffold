using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class MhpStoryData
    {
        public long SubStoryId { get; set; }
        public long OriginalEventId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public long UnitId { get; set; }
        public string ReadConditionTime { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionBossId { get; set; }
        public long ReadCondition { get; set; }
        public long RewardType { get; set; }
        public long RewardId { get; set; }
        public long RewardCount { get; set; }
    }
}
