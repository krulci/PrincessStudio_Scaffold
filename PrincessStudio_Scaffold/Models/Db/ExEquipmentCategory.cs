using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ExEquipmentCategory
    {
        public long Category { get; set; }
        public string CategoryName { get; set; }
        public string CategoryBase { get; set; }
        public string Outline { get; set; }
        public long RecycleItemId { get; set; }
    }
}
