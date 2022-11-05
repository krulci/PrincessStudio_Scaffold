using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SecretDungeonSchedule
    {
        public long DungeonAreaId { get; set; }
        public string TeaserTime { get; set; }
        public string StartTime { get; set; }
        public string CountStartTime { get; set; }
        public string EndTime { get; set; }
        public string CloseTime { get; set; }
    }
}
