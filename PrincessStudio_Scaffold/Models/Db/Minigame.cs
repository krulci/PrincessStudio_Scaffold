using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class Minigame
    {
        public long Id { get; set; }
        public long MinigameSchemeId { get; set; }
        public long EventId { get; set; }
        public long ReleaseConditions1 { get; set; }
        public long ConditionsId1 { get; set; }
        public long FirstTimeStoryId { get; set; }
        public long DisplayConditionType { get; set; }
        public long DisplayConditionId { get; set; }
        public long ResultChatConditionId { get; set; }
        public string ScoreUnit { get; set; }
        public long IsEnabledZeroScore { get; set; }
    }
}
