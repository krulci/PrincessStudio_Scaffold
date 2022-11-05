using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class VoiceGroup
    {
        public long GroupId { get; set; }
        public string GroupIdComment { get; set; }
        public long GroupUnitId01 { get; set; }
        public long GroupUnitId02 { get; set; }
        public long GroupUnitId03 { get; set; }
        public long GroupUnitId04 { get; set; }
        public long GroupUnitId05 { get; set; }
    }
}
