using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneDiaryData
    {
        public long DiaryId { get; set; }
        public long ContentsType { get; set; }
        public long DiaryDate { get; set; }
        public string SubTitle { get; set; }
        public string ForcedReleaseTime { get; set; }
        public string ConditionTime { get; set; }
        public long ConditionStoryId { get; set; }
        public long ConditionBossCount { get; set; }
    }
}
