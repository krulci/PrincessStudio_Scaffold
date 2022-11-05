using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class LtoStoryData
    {
        public long SubStoryId { get; set; }
        public long EventId { get; set; }
        public string Title { get; set; }
        public long ConditionStoryId { get; set; }
        public long RewardType { get; set; }
        public long RewardId { get; set; }
        public long RewardCount { get; set; }
    }
}
