using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ShioriQuestCondition
    {
        public long QuestId { get; set; }
        public long EventId { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionBossId { get; set; }
        public long ReleaseQuestId { get; set; }
        public long ReleaseBossId { get; set; }
        public long ConditionMainQuestId { get; set; }
    }
}
