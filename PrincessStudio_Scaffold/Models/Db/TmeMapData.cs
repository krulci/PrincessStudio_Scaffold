using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TmeMapData
    {
        public long TmeObjectId { get; set; }
        public long EventId { get; set; }
        public long ConditionStoryId { get; set; }
        public long AreaDifficultyType { get; set; }
        public long ReleaseEffect { get; set; }
        public long TapEffect { get; set; }
    }
}
