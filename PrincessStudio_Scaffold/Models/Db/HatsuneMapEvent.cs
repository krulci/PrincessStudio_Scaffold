using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneMapEvent
    {
        public long Id { get; set; }
        public long TargetEventId { get; set; }
        public long EventType { get; set; }
        public long ConditionId { get; set; }
        public long Param1 { get; set; }
        public long Param2 { get; set; }
    }
}
