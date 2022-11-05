using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class Banner
    {
        public long BannerId { get; set; }
        public long Type { get; set; }
        public long SystemId { get; set; }
        public long GachaId { get; set; }
        public long ConditionId { get; set; }
        public long Priority { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public long SubBannerId1 { get; set; }
        public long IsShowRoom { get; set; }
    }
}
