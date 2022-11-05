using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class EquipmentEnhanceData
    {
        public long PromotionLevel { get; set; }
        public long EquipmentEnhanceLevel { get; set; }
        public long NeededPoint { get; set; }
        public long TotalPoint { get; set; }
    }
}
