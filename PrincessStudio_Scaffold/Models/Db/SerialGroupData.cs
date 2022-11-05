using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SerialGroupData
    {
        public long SerialGroupId { get; set; }
        public string CampaignName { get; set; }
        public long SerialCampaignId1 { get; set; }
        public long SerialCampaignId2 { get; set; }
        public long SerialCampaignId3 { get; set; }
        public long SerialCampaignId4 { get; set; }
        public long SerialCampaignId5 { get; set; }
        public long SerialCampaignId6 { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
