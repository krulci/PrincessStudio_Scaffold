using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class CharacterLoveRankupText
    {
        public long CharaId { get; set; }
        public string Name { get; set; }
        public long LoveLevel { get; set; }
        public double Scale { get; set; }
        public long PositionX { get; set; }
        public long PositionY { get; set; }
        public long VoiceId1 { get; set; }
        public long Face1 { get; set; }
        public string Serif1 { get; set; }
        public long VoiceId2 { get; set; }
        public long Face2 { get; set; }
        public string Serif2 { get; set; }
        public long VoiceId3 { get; set; }
        public long Face3 { get; set; }
        public string Serif3 { get; set; }
    }
}
