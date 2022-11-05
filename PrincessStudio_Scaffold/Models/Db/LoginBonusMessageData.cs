using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class LoginBonusMessageData
    {
        public long Id { get; set; }
        public long LoginBonusId { get; set; }
        public long Type { get; set; }
        public long DayCount { get; set; }
        public long LuckPattern { get; set; }
        public long Rate { get; set; }
        public long CharacterId { get; set; }
        public string CharacterName { get; set; }
        public string Message { get; set; }
        public long VoiceId { get; set; }
        public long AdditionalType { get; set; }
        public string AdditionalParam { get; set; }
    }
}
