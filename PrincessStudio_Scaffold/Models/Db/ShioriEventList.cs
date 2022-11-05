using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ShioriEventList
    {
        public long EventId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long ConditionStoryId { get; set; }
        public long ConditionCharaId { get; set; }
        public long ConditionMainQuestId { get; set; }
        public long ConditionShioriQuestId { get; set; }
        public long OriginalEventId { get; set; }
        public string OriginalStartTime { get; set; }
        public long GojuonOrder { get; set; }
        public string HelpIndex { get; set; }
    }
}
