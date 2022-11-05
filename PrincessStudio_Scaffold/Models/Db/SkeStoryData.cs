using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SkeStoryData
    {
        public long SubStoryId { get; set; }
        public long OriginalEventId { get; set; }
        public string Title { get; set; }
        public long UnlockConditionQuestId { get; set; }
        public long UnlockConditionBossId { get; set; }
        public long ReadConditionEventStoryId { get; set; }
    }
}
