using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class UnitClipSetting
    {
        public long ClipId { get; set; }
        public long CenterX { get; set; }
        public long SizeX { get; set; }
        public long SoftnessX { get; set; }
    }
}
