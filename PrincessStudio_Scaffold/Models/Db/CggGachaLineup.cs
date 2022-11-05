using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class CggGachaLineup
    {
        public long Id { get; set; }
        public long GachaType { get; set; }
        public long LineupId { get; set; }
        public long GoodsId { get; set; }
        public long GoodsNum { get; set; }
    }
}
