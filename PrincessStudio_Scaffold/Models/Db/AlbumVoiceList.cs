﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class AlbumVoiceList
    {
        public long Id { get; set; }
        public long UnitId { get; set; }
        public string SheetId { get; set; }
        public string VoiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
