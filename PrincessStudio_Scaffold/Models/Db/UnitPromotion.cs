using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class UnitPromotion
    {
        public long UnitId { get; set; }
        public long PromotionLevel { get; set; }
        public long EquipSlot1 { get; set; }
        public long EquipSlot2 { get; set; }
        public long EquipSlot3 { get; set; }
        public long EquipSlot4 { get; set; }
        public long EquipSlot5 { get; set; }
        public long EquipSlot6 { get; set; }
    }
}
