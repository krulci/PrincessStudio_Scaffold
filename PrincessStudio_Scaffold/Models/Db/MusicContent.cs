using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class MusicContent
    {
        public long MusicId { get; set; }
        public string Name { get; set; }
        public string TotalPlayingTime { get; set; }
        public string ListenStartTime { get; set; }
        public string Detail { get; set; }
        public string SheetId { get; set; }
        public string CueId { get; set; }
    }
}
