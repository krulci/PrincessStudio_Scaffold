using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class WacData
    {
        public long WacId { get; set; }
        public long DateId { get; set; }
        public string UnlockTime { get; set; }
        public long PreDramaId { get; set; }
        public long PostDramaId { get; set; }
        public long IdleDramaId { get; set; }
        public long BgId { get; set; }
        public long EffectId { get; set; }
        public long MuralGroupId { get; set; }
        public double MuralOffsetX { get; set; }
        public long BirthdayLoginBonusId { get; set; }
        public long UnitId1 { get; set; }
        public long UnitId2 { get; set; }
        public long DrawEndToCenter { get; set; }
        public long UnitSearchId { get; set; }
    }
}
