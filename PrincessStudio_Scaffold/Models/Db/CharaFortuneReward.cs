using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class CharaFortuneReward
    {
        public long Id { get; set; }
        public long FortuneId { get; set; }
        public long Rank { get; set; }
        public long RewardType1 { get; set; }
        public long RewardId1 { get; set; }
        public long Count1 { get; set; }
        public long RewardType2 { get; set; }
        public long RewardId2 { get; set; }
        public long Count2 { get; set; }
        public long RewardType3 { get; set; }
        public long RewardId3 { get; set; }
        public long Count3 { get; set; }
        public long RewardType4 { get; set; }
        public long RewardId4 { get; set; }
        public long Count4 { get; set; }
        public long RewardType5 { get; set; }
        public long RewardId5 { get; set; }
        public long Count5 { get; set; }
    }
}
