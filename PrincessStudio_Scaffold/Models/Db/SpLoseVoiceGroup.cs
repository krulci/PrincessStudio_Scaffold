﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SpLoseVoiceGroup
    {
        public long GroupId { get; set; }
        public long UnitId { get; set; }
        public long SpeakerUnitId { get; set; }
    }
}
