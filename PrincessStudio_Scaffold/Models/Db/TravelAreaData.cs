using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TravelAreaData
    {
        public long TravelAreaId { get; set; }
        public string TravelAreaName { get; set; }
        public long ConditionTeamLv { get; set; }
        public long BgId { get; set; }
        public long TopIconId { get; set; }
        public long TopIconX { get; set; }
        public long TopIconY { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
