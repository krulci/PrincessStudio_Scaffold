using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ExceedLevelUnit
    {
        public long Id { get; set; }
        public long UnitId { get; set; }
        public long ExceedStage { get; set; }
        public long ExceedItemId { get; set; }
        public long ItemId1 { get; set; }
        public long RewardType1 { get; set; }
        public long ConsumeNum1 { get; set; }
        public long ItemId2 { get; set; }
        public long RewardType2 { get; set; }
        public long ConsumeNum2 { get; set; }
        public long ItemId3 { get; set; }
        public long RewardType3 { get; set; }
        public long ConsumeNum3 { get; set; }
        public long ItemId4 { get; set; }
        public long RewardType4 { get; set; }
        public long ConsumeNum4 { get; set; }
        public long ItemId5 { get; set; }
        public long RewardType5 { get; set; }
        public long ConsumeNum5 { get; set; }
    }
}
