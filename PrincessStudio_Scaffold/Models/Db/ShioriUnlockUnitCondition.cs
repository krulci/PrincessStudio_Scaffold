using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ShioriUnlockUnitCondition
    {
        public long Id { get; set; }
        public long UnitId { get; set; }
        public long EventId { get; set; }
        public long ConditionMissionId { get; set; }
        public string TopDescription { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
    }
}
