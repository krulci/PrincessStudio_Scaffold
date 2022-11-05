using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class Movie
    {
        public long MovieId { get; set; }
        public long StoryGroupId { get; set; }
        public long StoryId { get; set; }
        public string BgmId { get; set; }
        public string SeId { get; set; }
        public long MyPageFlag { get; set; }
        public long FadeLoopFlag { get; set; }
        public double BgmVolumeRate { get; set; }
    }
}
