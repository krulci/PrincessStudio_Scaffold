using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class VisualCustomize
    {
        public long Id { get; set; }
        public long TitlePrefab { get; set; }
        public long TitleMovie { get; set; }
        public long TitleVoice { get; set; }
        public long StoryTopMovie { get; set; }
        public long QuestTopMovie { get; set; }
        public long ProfileLogo { get; set; }
        public long WatchedStoryId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
