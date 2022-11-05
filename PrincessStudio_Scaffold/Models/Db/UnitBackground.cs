using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class UnitBackground
    {
        public long UnitId { get; set; }
        public string UnitName { get; set; }
        public long BgId { get; set; }
        public string BgName { get; set; }
        public double Position { get; set; }
        public long FaceType { get; set; }
    }
}
