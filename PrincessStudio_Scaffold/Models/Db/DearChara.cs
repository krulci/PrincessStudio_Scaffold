using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class DearChara
    {
        public long EventId { get; set; }
        public long CharaIndex { get; set; }
        public string CharaName { get; set; }
        public long MaxDearPoint { get; set; }
        public long ReferenceType { get; set; }
        public long ReferenceId { get; set; }
        public long EpisodeUnlockOffsetX { get; set; }
        public long EpisodeUnlockOffsetY { get; set; }
        public long DearPointUpOffsetX { get; set; }
        public long DearPointUpOffsetY { get; set; }
        public long ConditionStoryId { get; set; }
    }
}
