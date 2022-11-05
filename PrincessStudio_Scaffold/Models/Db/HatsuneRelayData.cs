using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneRelayData
    {
        public long RelayStoryId { get; set; }
        public long IsEnableRead { get; set; }
        public long ConditionQuestId { get; set; }
        public long StorySeq { get; set; }
        public string SubTitle { get; set; }
    }
}
