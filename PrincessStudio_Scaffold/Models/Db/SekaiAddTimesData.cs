using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SekaiAddTimesData
    {
        public long Id { get; set; }
        public long SekaiId { get; set; }
        public long AddTimes { get; set; }
        public long AddTimesLimit { get; set; }
        public string AddTimesTime { get; set; }
        public long Duration { get; set; }
    }
}
