using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class LoginBonusAdv
    {
        public long Id { get; set; }
        public long LoginBonusId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long CountKey { get; set; }
        public long AdvId { get; set; }
        public long ReadProcessFlag { get; set; }
    }
}
