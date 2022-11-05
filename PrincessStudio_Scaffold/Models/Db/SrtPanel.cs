using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SrtPanel
    {
        public long ReadingId { get; set; }
        public string Reading { get; set; }
        public long ReadType { get; set; }
        public long PanelId { get; set; }
        public string DetailText { get; set; }
        public long Version { get; set; }
    }
}
