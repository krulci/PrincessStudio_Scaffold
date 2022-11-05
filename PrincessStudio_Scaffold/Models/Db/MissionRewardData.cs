using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class MissionRewardData
    {
        public long Id { get; set; }
        public long MissionRewardId { get; set; }
        public long RewardType { get; set; }
        public long? RewardId { get; set; }
        public long RewardNum { get; set; }
        public long LvFrom { get; set; }
        public long LvTo { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
