using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ExceedLevelStage
    {
        public long ExceedStage { get; set; }
        public long IncreaseLevelLimit { get; set; }
        public long UnlockQuestId { get; set; }
        public long UnlockTeamLevel { get; set; }
        public long GeneralExceedItemId { get; set; }
    }
}
