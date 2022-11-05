using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class MypageFrame
    {
        public long FrameId { get; set; }
        public long GroupId { get; set; }
        public string FrameName { get; set; }
        public string Description { get; set; }
        public string StartTime { get; set; }
    }
}
