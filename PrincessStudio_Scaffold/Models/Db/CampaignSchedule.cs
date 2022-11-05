using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class CampaignSchedule
    {
        public long Id { get; set; }
        public long CampaignCategory { get; set; }
        public double Value { get; set; }
        public long SystemId { get; set; }
        public long IconImage { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long LevelId { get; set; }
        public long ShioriGroupId { get; set; }
        public long DuplicationOrder { get; set; }
        public long BeginnerId { get; set; }
    }
}
