using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SjrNpcActionOdds
    {
        public long Id { get; set; }
        public long ActionOddsId { get; set; }
        public long Distance { get; set; }
        public long Angle { get; set; }
        public long Rate { get; set; }
    }
}
