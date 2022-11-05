using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ClanCostGroup
    {
        public long Id { get; set; }
        public long CostGroupId { get; set; }
        public long Difficulty { get; set; }
        public long Count { get; set; }
        public long Cost { get; set; }
    }
}
