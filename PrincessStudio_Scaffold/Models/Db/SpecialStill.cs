using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SpecialStill
    {
        public long StillId { get; set; }
        public long Type { get; set; }
        public long BackMomoryType { get; set; }
        public long Value { get; set; }
    }
}
