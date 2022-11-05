using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SekaiTopStoryData
    {
        public long SekaiId { get; set; }
        public long StoryId { get; set; }
        public string BossTimeFrom { get; set; }
        public string BossTimeTo { get; set; }
    }
}
