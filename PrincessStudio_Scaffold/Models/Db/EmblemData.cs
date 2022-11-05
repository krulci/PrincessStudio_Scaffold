using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class EmblemData
    {
        public long EmblemId { get; set; }
        public long DispOder { get; set; }
        public long Type { get; set; }
        public string EmblemName { get; set; }
        public long DescriptionMissionId { get; set; }
        public long EventEmblem { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
