using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class UnitIntroduction
    {
        public long Id { get; set; }
        public long GachaId { get; set; }
        public long IntroductionNumber { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long MaximumChunkSize1 { get; set; }
        public long MaximumChunkSizeLoop1 { get; set; }
        public long MaximumChunkSize2 { get; set; }
        public long MaximumChunkSizeLoop2 { get; set; }
        public long MaximumChunkSize3 { get; set; }
        public long MaximumChunkSizeLoop3 { get; set; }
    }
}
