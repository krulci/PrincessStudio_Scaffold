using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SekaiTopData
    {
        public long Id { get; set; }
        public long SekaiId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long TopBg { get; set; }
        public long PositionX { get; set; }
        public long PositionY { get; set; }
        public double ScaleRatio { get; set; }
        public string SheetId { get; set; }
        public string QueId { get; set; }
        public long BossMode { get; set; }
        public long SekaiBossModeId { get; set; }
        public string BossHpFrom { get; set; }
        public string BossHpTo { get; set; }
        public string BossTimeFrom { get; set; }
        public string BossTimeTo { get; set; }
        public long Duration { get; set; }
        public long StoryId { get; set; }
    }
}
