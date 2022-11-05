using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class UniqueEquipmentEnhanceData
    {
        public long EquipSlot { get; set; }
        public long EnhanceLevel { get; set; }
        public long NeededPoint { get; set; }
        public long TotalPoint { get; set; }
        public long NeededMana { get; set; }
        public long Rank { get; set; }
    }
}
