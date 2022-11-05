using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ClanBattleRecommendData
    {
        public long LevelId { get; set; }
        public long RecommendGroup { get; set; }
        public long LevelFrom { get; set; }
        public long LevelTo { get; set; }
        public long AtackPartyCount { get; set; }
        public long MagicPartyCount { get; set; }
    }
}
