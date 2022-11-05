using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class RoomItemDetail
    {
        public long RoomItemId { get; set; }
        public long Level { get; set; }
        public string ItemDetail { get; set; }
        public long LvupTriggerType { get; set; }
        public long LvupTriggerId { get; set; }
        public long LvupTriggerValue { get; set; }
        public long LvupTriggerType2 { get; set; }
        public long LvupTriggerId2 { get; set; }
        public long LvupTriggerValue2 { get; set; }
        public long LvupItem1Type { get; set; }
        public long LvupItem1Id { get; set; }
        public long LvupItem1Num { get; set; }
        public long LvupTime { get; set; }
    }
}
