using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class RoomEffectRewardGet
    {
        public long Id { get; set; }
        public long Level { get; set; }
        public long RewardType { get; set; }
        public long RewardId { get; set; }
        public long MaxCount { get; set; }
        public long IncStep { get; set; }
        public long IntervalSecond { get; set; }
        public string StockMinStep { get; set; }
        public string StockMidStep { get; set; }
    }
}
