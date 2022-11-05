using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class NyxStoryData
    {
        public long StoryId { get; set; }
        public long StorySeq { get; set; }
        public long StoryPhase { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ReadConditionTime { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionBossCount { get; set; }
        public long AdvFlg { get; set; }
        public long AdvId { get; set; }
    }
}
