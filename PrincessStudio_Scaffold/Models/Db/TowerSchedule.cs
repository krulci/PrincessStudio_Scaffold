using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TowerSchedule
    {
        public long TowerScheduleId { get; set; }
        public long MaxTowerAreaId { get; set; }
        public long OpeningStoryId { get; set; }
        public string CountStartTime { get; set; }
        public string RecoveryDisableTime { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
