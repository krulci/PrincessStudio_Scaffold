using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SerialCodeData
    {
        public long SerialCampaignId { get; set; }
        public long SerialGroupId { get; set; }
        public string CampaignName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long LimitNum { get; set; }
    }
}
