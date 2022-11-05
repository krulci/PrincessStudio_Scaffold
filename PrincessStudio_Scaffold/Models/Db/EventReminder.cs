using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class EventReminder
    {
        public long ReminderId { get; set; }
        public long EventId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string TitleText { get; set; }
        public string DescriptionText { get; set; }
        public string NoticeText { get; set; }
        public long ThumbnailId { get; set; }
        public string BtnText { get; set; }
        public long TargetType { get; set; }
        public long TargetId { get; set; }
    }
}
