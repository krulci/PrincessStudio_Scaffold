using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class PkbDramaData
    {
        public long DramaId { get; set; }
        public long ConditionPitcherId1 { get; set; }
        public long ConditionPitcherId2 { get; set; }
        public long ConditionBatterId1 { get; set; }
        public long ConditionBatterId2 { get; set; }
    }
}
