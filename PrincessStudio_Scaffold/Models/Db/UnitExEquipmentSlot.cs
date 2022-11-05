using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class UnitExEquipmentSlot
    {
        public long UnitId { get; set; }
        public long SlotCategory1 { get; set; }
        public long SlotCategory2 { get; set; }
        public long SlotCategory3 { get; set; }
    }
}
