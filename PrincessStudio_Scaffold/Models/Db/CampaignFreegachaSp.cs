using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class CampaignFreegachaSp
    {
        public long CampaignId { get; set; }
        public long MaxExecCount { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
