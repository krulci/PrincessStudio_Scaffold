using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TaqUnit
    {
        public long UnitId { get; set; }
        public long SortOrder { get; set; }
        public long PersonalityId { get; set; }
        public long GenreStatus1 { get; set; }
        public long GenreStatus2 { get; set; }
        public long GenreStatus3 { get; set; }
        public long GenreStatus4 { get; set; }
        public long GenreStatus5 { get; set; }
        public long GenreStatus6 { get; set; }
    }
}
