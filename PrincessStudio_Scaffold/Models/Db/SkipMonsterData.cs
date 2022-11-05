using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SkipMonsterData
    {
        public long QuestId { get; set; }
        public long AreaId { get; set; }
        public string QuestName { get; set; }
        public long WaveGroupId1 { get; set; }
        public long BgSkipId { get; set; }
    }
}
