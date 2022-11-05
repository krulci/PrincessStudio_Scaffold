using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class KaiserSchedule
    {
        public long Id { get; set; }
        public string TeaserTime { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string CountStartTime { get; set; }
        public string CloseTime { get; set; }
        public long StoryId { get; set; }
        public long CloseStoryConditionId { get; set; }
        public long CloseStoryId { get; set; }
        public string TopBgm { get; set; }
        public string TopBg { get; set; }
        public string AfterBgm { get; set; }
        public string AfterBg { get; set; }
    }
}
