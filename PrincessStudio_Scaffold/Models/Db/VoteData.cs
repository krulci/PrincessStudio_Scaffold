using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class VoteData
    {
        public long VoteId { get; set; }
        public string VoteStartTime { get; set; }
        public string VoteEndTime { get; set; }
        public string ResultStartTime { get; set; }
        public string ResultEndTime { get; set; }
        public long StartStoryId { get; set; }
        public long ResultStoryId { get; set; }
    }
}
