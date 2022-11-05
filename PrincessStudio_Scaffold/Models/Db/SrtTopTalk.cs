﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SrtTopTalk
    {
        public long Id { get; set; }
        public long TalkId { get; set; }
        public long CharaIndex { get; set; }
        public string TalkText { get; set; }
        public string SheetName { get; set; }
        public string CueName { get; set; }
        public long Direction { get; set; }
    }
}
