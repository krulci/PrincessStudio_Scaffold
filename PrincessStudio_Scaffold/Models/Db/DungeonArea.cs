using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class DungeonArea
    {
        public long DungeonAreaId { get; set; }
        public long DungeonType { get; set; }
        public string DungeonName { get; set; }
        public string Description { get; set; }
        public long OpenAreaId { get; set; }
        public long OpenQuestId { get; set; }
        public long ContentReleaseStory { get; set; }
        public long InitialClearStory { get; set; }
        public long RewardGroupId { get; set; }
        public long RecommendLevel { get; set; }
        public long QuestPositionX { get; set; }
        public long QuestPositionY { get; set; }
        public long IconId { get; set; }
        public long RecoveryHpRate { get; set; }
        public long RecoveryTpRate { get; set; }
    }
}
