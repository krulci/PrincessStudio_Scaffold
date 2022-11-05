using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class EventTopAdv
    {
        public long EventTopAdvId { get; set; }
        public long EventId { get; set; }
        public long Type { get; set; }
        public long Value1 { get; set; }
        public long Value2 { get; set; }
        public long Value3 { get; set; }
        public long StoryId { get; set; }
        public long CharacterId { get; set; }
        public long ConditionType { get; set; }
        public long ConditionStoryId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
