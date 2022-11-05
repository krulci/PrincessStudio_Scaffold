using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class RoomItemGetAnnouncement
    {
        public long Id { get; set; }
        public long RoomItemId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string GetDate { get; set; }
        public string RoomAnnouncementName { get; set; }
    }
}
