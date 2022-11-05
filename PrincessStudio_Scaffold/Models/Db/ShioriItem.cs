using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ShioriItem
    {
        public long EventId { get; set; }
        public long UnitMaterialId1 { get; set; }
        public long UnitMaterialId2 { get; set; }
    }
}
