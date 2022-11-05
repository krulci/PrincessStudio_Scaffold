using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class DailyMissionData
    {
        public long DailyMissionId { get; set; }
        public long DispGroup { get; set; }
        public long CategoryIcon { get; set; }
        public string Description { get; set; }
        public long MissionCondition { get; set; }
        public long? ConditionValue1 { get; set; }
        public long? ConditionValue2 { get; set; }
        public long? ConditionValue3 { get; set; }
        public long ConditionNum { get; set; }
        public long MissionRewardId { get; set; }
        public long? SystemId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long MinLevel { get; set; }
        public long MaxLevel { get; set; }
        public long TitleColorId { get; set; }
        public long VisibleFlag { get; set; }
    }
}
