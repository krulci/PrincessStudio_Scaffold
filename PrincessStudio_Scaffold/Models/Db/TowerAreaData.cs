using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TowerAreaData
    {
        public long TowerAreaId { get; set; }
        public long MaxFloorNum { get; set; }
        public long AreaBg { get; set; }
        public string TowerBgm { get; set; }
        public long CloisterQuestId { get; set; }
    }
}
