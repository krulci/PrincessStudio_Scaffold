using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class EventGachaData
    {
        public long GachaId { get; set; }
        public long EventId { get; set; }
        public string GachaName { get; set; }
        public long ItemType { get; set; }
        public long ItemId { get; set; }
        public long Cost { get; set; }
        public long RepeatStep { get; set; }
    }
}
