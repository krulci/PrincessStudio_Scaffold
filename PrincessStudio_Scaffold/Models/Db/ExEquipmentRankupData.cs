using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ExEquipmentRankupData
    {
        public long Rarity { get; set; }
        public long RankupLevel { get; set; }
        public long ConsumeGold { get; set; }
        public long ItemId { get; set; }
    }
}
