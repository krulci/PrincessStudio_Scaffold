using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class GoldsetData2
    {
        public long Id { get; set; }
        public long BuyCount { get; set; }
        public long UseJewelCount { get; set; }
        public long GetGoldCount { get; set; }
        public long GoldsetOdds1 { get; set; }
        public long GoldsetOdds2 { get; set; }
        public long GoldsetOdds3 { get; set; }
        public long AdditionalGoldMinRate { get; set; }
        public long AdditionalGoldMaxRate { get; set; }
        public long TrainingQuestCount { get; set; }
    }
}
