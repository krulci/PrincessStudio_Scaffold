using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class PkbBatterCondition
    {
        public long BatterId { get; set; }
        public long PkbScore { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public long Meet { get; set; }
        public long Critical { get; set; }
        public long Power { get; set; }
        public string AbilityName { get; set; }
        public string AbilityDetail { get; set; }
        public long IsPlayable { get; set; }
    }
}
