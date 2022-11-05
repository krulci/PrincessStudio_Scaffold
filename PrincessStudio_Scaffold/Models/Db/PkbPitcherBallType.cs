using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class PkbPitcherBallType
    {
        public long PitcherId { get; set; }
        public long BallType { get; set; }
        public string BallTypeName { get; set; }
    }
}
