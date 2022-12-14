using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class OmpStoryData
    {
        public long OmpStoryId { get; set; }
        public long EventId { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionBossId { get; set; }
        public long StorySeq { get; set; }
        public long IsReadableOnResult { get; set; }
        public long RewardType { get; set; }
        public long RewardId { get; set; }
        public long RewardCount { get; set; }
        public string SubTitle { get; set; }
    }
}
