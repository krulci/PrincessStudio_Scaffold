using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class DefineSpskill
    {
        public long LinkSkillSlot { get; set; }
        public long SpSkillId { get; set; }
        public long BaseSkillId { get; set; }
        public long SkillCategory { get; set; }
    }
}
