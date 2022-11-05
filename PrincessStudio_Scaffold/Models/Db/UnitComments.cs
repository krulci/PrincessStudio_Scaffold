using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class UnitComments
    {
        public long Id { get; set; }
        public long UnitId { get; set; }
        public long UseType { get; set; }
        public long VoiceId { get; set; }
        public long FaceId { get; set; }
        public double ChangeTime { get; set; }
        public long ChangeFace { get; set; }
        public string Description { get; set; }
        public long AllCommentsFlag { get; set; }
        public long TargetUnitId { get; set; }
        public long FaceId2 { get; set; }
        public double ChangeTime2 { get; set; }
        public long ChangeFace2 { get; set; }
        public long FaceId3 { get; set; }
        public double ChangeTime3 { get; set; }
        public long ChangeFace3 { get; set; }
    }
}
