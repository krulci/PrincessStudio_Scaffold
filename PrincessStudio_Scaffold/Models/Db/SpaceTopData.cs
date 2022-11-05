using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SpaceTopData
    {
        public long Id { get; set; }
        public long SpaceId { get; set; }
        public long SpaceBattleId { get; set; }
        public long PartFlag { get; set; }
        public long StoryId { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
        public string SkipBattleTime { get; set; }
        public string Name { get; set; }
    }
}
