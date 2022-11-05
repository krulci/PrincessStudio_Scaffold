using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class QuestConditionData
    {
        public long QuestId { get; set; }
        public long ConditionQuestId1 { get; set; }
        public long ConditionQuestId2 { get; set; }
        public long ConditionQuestId3 { get; set; }
        public long ConditionQuestId4 { get; set; }
        public long ConditionQuestId5 { get; set; }
        public long ReleaseQuestId1 { get; set; }
        public long ReleaseQuestId2 { get; set; }
        public long ReleaseQuestId3 { get; set; }
        public long ReleaseQuestId4 { get; set; }
        public long ReleaseQuestId5 { get; set; }
    }
}
