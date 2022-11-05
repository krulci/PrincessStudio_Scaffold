using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class NopDramaData
    {
        public long Id { get; set; }
        public long StageId { get; set; }
        public long PositionId1 { get; set; }
        public long PositionId2 { get; set; }
        public long PositionId3 { get; set; }
        public long ColSizeX { get; set; }
        public long ColSizeY { get; set; }
        public double ColPosY { get; set; }
        public double TalkPosX { get; set; }
        public double TalkPosY { get; set; }
        public long IdleDramaId { get; set; }
        public long TalkDramaId { get; set; }
        public long EventDramaId { get; set; }
        public long CreateBackDramaId { get; set; }
        public long CreateFrontDramaId { get; set; }
        public long SubStoryId { get; set; }
    }
}
