using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ItemData
    {
        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public long PromotionLevel { get; set; }
        public long ItemType { get; set; }
        public long Value { get; set; }
        public long Price { get; set; }
        public long LimitNum { get; set; }
        public long GojuonOrder { get; set; }
        public long SellCheckDisp { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
