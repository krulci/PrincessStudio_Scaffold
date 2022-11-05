using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneQuiz
    {
        public long EventId { get; set; }
        public long QuizId { get; set; }
        public string QuestionTitle { get; set; }
        public string Question { get; set; }
        public string Choice1 { get; set; }
        public string Choice2 { get; set; }
        public string Choice3 { get; set; }
        public string Choice4 { get; set; }
        public string Choice5 { get; set; }
        public string Choice6 { get; set; }
        public long Answer { get; set; }
        public string Hint { get; set; }
        public long ResourceId { get; set; }
        public long ReleaseQuestId { get; set; }
        public long QuizPositionX { get; set; }
        public long QuizPositionY { get; set; }
        public long QuizIconId { get; set; }
        public string QuizPointName { get; set; }
        public long AdvIdQuizStart { get; set; }
        public long AdvIdQuizEnd { get; set; }
    }
}
