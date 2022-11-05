using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class RoomChatScenario
    {
        public long Id { get; set; }
        public long ScenarioIdx { get; set; }
        public long UnitPosNo { get; set; }
        public long Delay { get; set; }
        public long AffectType { get; set; }
        public long AnimeId { get; set; }
        public long IconId { get; set; }
    }
}
