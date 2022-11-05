using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneUnlockStoryCondition
    {
        public long StoryId { get; set; }
        public long EventId { get; set; }
        public long ConditionEntry { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionBossId { get; set; }
        public long ConditionMissionId { get; set; }
        public string ConditionTime { get; set; }
        public long ConditionStoryId { get; set; }
    }
}
