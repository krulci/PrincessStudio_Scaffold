using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class LegionMissionData
    {
        public long LegionMissionId { get; set; }
        public long CategoryId { get; set; }
        public long DispGroup { get; set; }
        public string Description { get; set; }
        public long MissionCondition { get; set; }
        public long LegionBossId { get; set; }
        public long ConditionValue { get; set; }
        public string ConditionNum { get; set; }
        public long MissionRewardId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
