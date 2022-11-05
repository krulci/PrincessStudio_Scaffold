using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ArcadeList
    {
        public long ArcadeId { get; set; }
        public string Title { get; set; }
        public string StartTime { get; set; }
        public long Price { get; set; }
        public string SheetId { get; set; }
        public string CueId { get; set; }
        public long WhereType { get; set; }
        public string BannerStartTime { get; set; }
        public string BannerEndTime { get; set; }
        public string Description { get; set; }
    }
}
