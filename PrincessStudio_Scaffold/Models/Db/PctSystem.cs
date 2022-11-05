using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class PctSystem
    {
        public long Id { get; set; }
        public long PctBaseSpeed { get; set; }
        public long FeverPointMax { get; set; }
        public long FeverTime { get; set; }
        public long FeverReventionTime { get; set; }
        public long PctTime { get; set; }
        public long Chara1 { get; set; }
        public long Chara2 { get; set; }
        public long Chara1GaugeChoice { get; set; }
        public long Chara2GaugeChoice { get; set; }
    }
}
