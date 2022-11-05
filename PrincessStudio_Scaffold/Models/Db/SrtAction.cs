using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SrtAction
    {
        public string ActionName { get; set; }
        public string InoriAction { get; set; }
        public string DragonAction { get; set; }
        public string KayaAction { get; set; }
        public string HomareAction { get; set; }
        public long TalkTextType { get; set; }
        public string TalkText { get; set; }
        public string VoiceList { get; set; }
    }
}
