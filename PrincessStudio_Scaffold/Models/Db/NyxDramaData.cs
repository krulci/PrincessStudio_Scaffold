using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class NyxDramaData
    {
        public long DramaId { get; set; }
        public long StoryPhase { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public long ConditionUnlockedStoryId { get; set; }
        public long ConditionLockedStoryId { get; set; }
    }
}
