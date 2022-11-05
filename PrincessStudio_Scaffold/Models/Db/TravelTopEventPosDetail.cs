using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TravelTopEventPosDetail
    {
        public long PosId { get; set; }
        public long PosGroupId { get; set; }
        public long PosX { get; set; }
        public long PosY { get; set; }
        public long AllPosFlag { get; set; }
    }
}
