using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class WacMuralBgData
    {
        public long WacId { get; set; }
        public long DateId { get; set; }
        public long BgId { get; set; }
        public long Type { get; set; }
        public string StartOffsetX { get; set; }
        public string EndOffsetX { get; set; }
    }
}
