using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SdNaviComment
    {
        public long CommentId { get; set; }
        public long WhereType { get; set; }
        public long CharacterId { get; set; }
        public long MotionType { get; set; }
        public string Description { get; set; }
        public long VoiceId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
