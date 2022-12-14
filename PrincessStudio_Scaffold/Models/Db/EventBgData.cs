using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class EventBgData
    {
        public long EventId { get; set; }
        public long BgId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
