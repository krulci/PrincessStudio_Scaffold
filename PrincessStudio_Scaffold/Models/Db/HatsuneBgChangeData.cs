using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneBgChangeData
    {
        public long Id { get; set; }
        public long AreaId { get; set; }
        public long ConditionType { get; set; }
        public long ConditionId { get; set; }
        public long TargetType { get; set; }
        public long BgAfterChangeId { get; set; }
    }
}
