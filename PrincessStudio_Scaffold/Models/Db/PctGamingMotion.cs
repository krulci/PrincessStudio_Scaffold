using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class PctGamingMotion
    {
        public long MotionId { get; set; }
        public long PerfectCount { get; set; }
        public long GoodCount { get; set; }
        public long NiceCount { get; set; }
        public long Point { get; set; }
    }
}
