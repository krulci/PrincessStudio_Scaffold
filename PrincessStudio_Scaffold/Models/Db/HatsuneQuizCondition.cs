using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneQuizCondition
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public long QuizId { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionQuizId { get; set; }
        public long ConditionUnitId { get; set; }
        public long ConditionMissionId { get; set; }
        public long ConditionTimeFrom { get; set; }
    }
}
