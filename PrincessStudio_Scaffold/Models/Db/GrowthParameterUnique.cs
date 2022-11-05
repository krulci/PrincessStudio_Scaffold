using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class GrowthParameterUnique
    {
        public long GrowthId { get; set; }
        public long UniqueEquipStrengthPoint1 { get; set; }
        public long UniqueEquipStrengthPoint2 { get; set; }
        public long UniqueEquipRank1 { get; set; }
        public long UniqueEquipRank2 { get; set; }
    }
}
