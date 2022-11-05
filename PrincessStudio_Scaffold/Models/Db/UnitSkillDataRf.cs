using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class UnitSkillDataRf
    {
        public long Id { get; set; }
        public long SkillId { get; set; }
        public long RfSkillId { get; set; }
        public long MinLv { get; set; }
        public long MaxLv { get; set; }
    }
}
