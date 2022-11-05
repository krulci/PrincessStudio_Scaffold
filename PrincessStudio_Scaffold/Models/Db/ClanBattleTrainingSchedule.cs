using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ClanBattleTrainingSchedule
    {
        public long TrainingId { get; set; }
        public long ClanBattleId { get; set; }
        public string BattleStartTime { get; set; }
        public string BattleEndTime { get; set; }
        public string IntervalStartTime { get; set; }
        public string IntervalEndTime { get; set; }
    }
}
