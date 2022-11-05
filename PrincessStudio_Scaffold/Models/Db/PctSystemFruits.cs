using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class PctSystemFruits
    {
        public long Id { get; set; }
        public long LastTime { get; set; }
        public long Appearance { get; set; }
        public long BarSplit { get; set; }
        public long AppearanceCharaOdds { get; set; }
        public string AppearancePattern { get; set; }
        public long WaitTime { get; set; }
    }
}
