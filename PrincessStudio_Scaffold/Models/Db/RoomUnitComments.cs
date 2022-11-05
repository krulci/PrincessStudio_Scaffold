using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class RoomUnitComments
    {
        public long Id { get; set; }
        public long UnitId { get; set; }
        public long Trigger { get; set; }
        public long VoiceId { get; set; }
        public long BelovedStep { get; set; }
        public long Time { get; set; }
        public long FaceId { get; set; }
        public string Description { get; set; }
        public long InsertWordType { get; set; }
    }
}
