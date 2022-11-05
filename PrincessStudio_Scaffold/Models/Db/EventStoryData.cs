using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class EventStoryData
    {
        public long StoryGroupId { get; set; }
        public long StoryType { get; set; }
        public long Value { get; set; }
        public string Title { get; set; }
        public long ThumbnailId { get; set; }
        public long DispOrder { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
